﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Data.SQLite;
using TagLib;
using WMPLib;

namespace MusicDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
            connection = new SQLiteConnection();
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            loadAll_Click(null, null);
        }

        //Забезпечує виконання роботи у окремому потоці
        private BackgroundWorker bw;
        //Зберігає шлях до обранного каталогу
        private String folderName = "";
        //Лічильники стану
        private int totalFolders = 0;
        private int totalFiles = 0;
        private int songCount = 0;
        //Ім'я бази даних
        const string databaseName = @"cyber.db";
        SQLiteConnection connection;
        DateTime a = new DateTime();
        DateTime b = new DateTime();

        private void openFolderButton_click(object sender, EventArgs e) //Діалог вибору каталогу
        {
            //Показує діалог вибору каталогу идля сканування
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                openFolderPathBox.Text = folderName; //Відображаємо цей шлях для користувача
            }
        }

        private void FilesInSubDirectories(string foldPath) //Скануємо каталог на наявність підкаталогів
        {
            DirectoryInfo parentDirectory = new DirectoryInfo(foldPath);
            DirectoryInfo[] subDirectories = parentDirectory.GetDirectories("*",SearchOption.AllDirectories);
            foreach (DirectoryInfo dir in subDirectories)
            {
                if (bw.CancellationPending) return; //Якщо завдання було скасовано - вихід
                ParseAudio(dir); //Скануємо всі файли у цьому каталозі
            }
        }

		private void ParseAudio(DirectoryInfo dir) //Сканує аудіо файли на наявність тегів
		{
            SQLiteTransaction transaction = connection.BeginTransaction();

            int count = 0;
            FileInfo[] files = dir.GetFiles("*.*"); //Список усіх файлів у цьому каталозі
            foreach (FileInfo file in files)
			{
                count++;
                totalFiles++;
                String songName = "";
                if (bw.CancellationPending) return; //Якщо задача була скасована - вихід
                if(TagLib.SupportedMimeType.AllExtensions.Contains(file.Extension.ToLower().Replace(".", ""))) //Якщо розширення файла відповідає медіа-файлу
                {
                    try
                    {
                        TagLib.File tagFile = TagLib.File.Create(file.FullName);
                        if (TagLib.MediaTypes.Audio == tagFile.Properties.MediaTypes) //Якщо цей медіа-файл є аудіо-файлом
                        {
                            if (tagFile.Tag.IsEmpty == false) //Якщо у ньому є теги
                            {   //Зчитуємо усі теги
                                String artist_name = toUtf8(tagFile.Tag.FirstPerformer);
                                String album_name = toUtf8(tagFile.Tag.Album);
                                String genre_name = toUtf8(tagFile.Tag.FirstGenre);
                                String track_year = toUtf8(tagFile.Tag.Year.ToString());
                                String track_name = toUtf8(tagFile.Tag.Title);
                                String track_path = toUtf8(tagFile.Name);
                                //Якщо немає елементарних даних (виконавець - назва пісні) - переходимо до іншого
                                if (String.IsNullOrEmpty(artist_name) || String.IsNullOrWhiteSpace(artist_name)) continue;
                                if (String.IsNullOrEmpty(track_name) || String.IsNullOrWhiteSpace(track_name)) continue;
                                //Додаємо у базу інформацію про виконавця
                                String[] artist_columns = {"artist_name"};
                                String[] artist_values = { artist_name };
                                dbInsert("artist", artist_columns, artist_values, connection);
                                String artistId = dbGetID("artist", "artist_name", artist_name, connection);
                                //Якщо є інформація про жанр - додаємо до бази
                                String genreId = "";
                                if (!String.IsNullOrEmpty(genre_name) || !String.IsNullOrWhiteSpace(genre_name))
                                {
                                    String[] genre_columns = { "genre_name" };
                                    String[] genre_values = { genre_name };
                                    dbInsert("genre", genre_columns, genre_values, connection);
                                    genreId = dbGetID("genre", "genre_name", genre_name, connection);
                                }
                                //Якщо є інформація про альбом - додаємо до бази
                                String albumId = "";
                                if (!String.IsNullOrEmpty(album_name) || !String.IsNullOrWhiteSpace(album_name))
                                {
                                    String[] album_columns = { "album_name" };
                                    String[] album_values = { album_name };
                                    dbInsert("album", album_columns, album_values, connection);
                                    albumId = dbGetID("album", "album_name", album_name, connection);
                                }

                                if (!String.IsNullOrEmpty(albumId))
                                {
                                    String[] artist_albums_columns = { "artist_id", "album_id" };
                                    String[] artist_albums_values = { artistId, albumId };
                                    dbInsert("artist_albums", artist_albums_columns, artist_albums_values, connection);
                                }

                                String[] track_columns = { "track_name", "artist_id", "album_id", "track_path", "track_year", "genre_id" };
                                String[] track_values = { track_name, artistId, albumId, track_path, track_year, genreId };
                                dbInsert("track", track_columns, track_values, connection);

                                songName = artist_name + " - " + track_name + Environment.NewLine;
                                songCount++;
                            }

                        }
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message + Environment.NewLine + file.FullName);
                    }
                    
                }
                //Якщо ввімкнено опцію показу стану сканування - виводимо інформацію
                if (showProcessCheckBox.Checked == true)
                {
                    String[] result = new String[4];
                    result[0] = songName;
                    result[1] = count.ToString();
                    result[2] = files.Length.ToString();
                    result[3] = dir.Name;
                    bw.ReportProgress(0, result);
                }
			}
            totalFolders++;
            transaction.Commit(); //Підтверджуємо транзакцію додавання до бази
		}

        public string toUtf8(string unknown) //Конвертуємо усі теги у UTF-8
        {
            if (String.IsNullOrEmpty(unknown)) return unknown;

            return new string(unknown.ToCharArray().
                Select(x => ((x + 848) >= 'А' && (x + 848) <= 'ё') ? (char)(x + 848) : x). //Перевіряємо чи є текст кирилицею, та повертаємо utf-8
                ToArray());
        }

        private void parseButton_click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(openFolderPathBox.Text) == false && String.IsNullOrWhiteSpace(openFolderPathBox.Text) == false) folderName = openFolderPathBox.Text;
            else
            {
                MessageBox.Show("Оберіть каталог для сканування!", "Увага!");
                return;
            }
            DirectoryInfo folder = new DirectoryInfo(folderName);
            if(folder.Exists == false)
            {
                MessageBox.Show("Каталог не існує, або шлях вказаний невірно!", "Увага!");
                return;
            }

            if (bw.IsBusy != true)
            {
                parsingStatusLabel.Text = "Статус: Сканування...";
                parsingProgressBar.Style = ProgressBarStyle.Marquee;
                totalFolders = 0;
                totalFiles = 0;
                songCount = 0;
                outPutText.Text = "";
                bw.RunWorkerAsync();
            }
        }
        //Виконуємо операції у окремому потоці, для того, щоб не навантажувати основний потік, що оновлює інтерфейс користувача
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                }
                else
                {
                    a = DateTime.Now;
                    DirectoryInfo folder = new DirectoryInfo(folderName);
                    initDbConnection(); //Ініціалізуємо зв'зок з базою
                    connection.Open();
                    if (subdirectCheckBox.Checked) //Сканування підкаталогів
                    {
                        ParseAudio(folder);
                        FilesInSubDirectories(folderName);
                    }
                    else
                    {
                        ParseAudio(folder);
                    }
                    connection.Close();
                    b = DateTime.Now;
                    if (worker.CancellationPending == true) //Перевіряємо, чи завдання було відмінено в ході виконання
                    {
                        e.Cancel = true;
                    }
                }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            String time = b.Subtract(a).ToString();
            time = time.Remove(time.Length - 3, 3);

            if ((e.Cancelled == true))
            {
                this.parsingStatusLabel.Text = "Статус: Відмінено!";
                this.parsingProgressBar.Style = ProgressBarStyle.Blocks;
            }

            else if (!(e.Error == null))
            {
                this.parsingStatusLabel.Text = ("Статус: Помилка: " + e.Error.Message);
                this.parsingProgressBar.Style = ProgressBarStyle.Blocks;
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(15, "Помилка!", e.Error.Message, ToolTipIcon.Error);
            }

            else
            {
                this.parsingStatusLabel.Text = "Статус: Завершено!";
                this.toolStripProgressLabel.Text = "Завершено!";
                this.parsingProgressBar.Style = ProgressBarStyle.Blocks;
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(15,"Завершено!", "Знайдено: " + songCount + Environment.NewLine + "Проскановано: файлів " + totalFiles + ", каталогів " + totalFolders, ToolTipIcon.Info);
                loadAll.PerformClick();
            }
            this.outPutText.AppendText("Час виконання: " + time);
            this.toolStripProgressLabel.Text += " Час виконання: " + time;
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null && bw.CancellationPending == false && showProcessCheckBox.Checked == true)
            {
                String[] result = (String[])e.UserState;
                if(String.IsNullOrEmpty(result[0]) == false) this.outPutText.AppendText(result[0]);
                this.toolStripProgressLabel.Text = result[3] + ": " + result[1] + "/" + result[2];
                this.toolStripProgressCountLabel.Text = "Знайдено: " + songCount + " Проскановано: файлів " + totalFiles + ", каталогів " + totalFolders;
            }
        }

        private void stopParsingButton_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();
            }
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();
            }

            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        //Метод додавання у базу інформації
        private void dbInsert(String tableName, String[] columnsArray, String[] valuesArray, SQLiteConnection connection)
        {
            String conditionString = "";
            String valuesString = "";
            String columnsString = "";

            if (columnsArray.Length != valuesArray.Length) return;
            for (int i = 0; i < columnsArray.Length; i++)
            {
                String column = columnsArray[i];
                String value = valuesArray[i].Replace("'", "''");
                columnsString += " '" + column + "' ";
                valuesString += " '" + value + "' ";
                conditionString += " " + column + " = '" + value + "' ";

                if (i + 1 != valuesArray.Length)
                {
                    columnsString += ", "; //if not last element
                    valuesString += ", "; //if not last element
                    conditionString += " AND "; //if not last element
                }
            }
            
            SQLiteCommand insert = new SQLiteCommand("INSERT INTO " + tableName + " ( " + columnsString + " ) " +
                                                       "SELECT " + valuesString + " " +
                                                       "WHERE NOT EXISTS (SELECT 1 FROM " + tableName + " WHERE " + conditionString + " );", connection);
            insert.ExecuteNonQuery();
        }

        private String dbGetID(String tableName, String columnName, String value, SQLiteConnection connection)
        {
            String result = "NULL";
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT " + tableName + "_id" + " FROM " + tableName + " WHERE " + columnName + " = '" + value.Replace("'", "''") + "' ;", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    // Перевіряємо, чи є рядки для читання
                    if (reader.HasRows)
                    {
                        // Читаємо усі рядки
                        while (reader.Read())
                        {
                            // Шукаємо стовбець за ім'ям
                            int idColumnIndex = reader.GetOrdinal(tableName + "_id");
                            // Перевіряємо, чи стовбець не пустий
                            if (!reader.IsDBNull(idColumnIndex))
                            {
                                int id = reader.GetInt32(idColumnIndex);
                                result = id.ToString();
                            }
                        }

                    }
                    return result;
                }
            }
        }

        private void initDbConnection()
        {
            connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();

            SQLiteCommand createArtistTable = connection.CreateCommand();
            createArtistTable.CommandText = "CREATE TABLE IF NOT EXISTS `artist` (`artist_id` INTEGER PRIMARY KEY AUTOINCREMENT, `artist_name` TEXT NOT NULL);";
            createArtistTable.ExecuteNonQuery();

            SQLiteCommand createGenreTable = connection.CreateCommand();
            createGenreTable.CommandText = "CREATE TABLE IF NOT EXISTS `genre` (`genre_id` INTEGER PRIMARY KEY AUTOINCREMENT, `genre_name` TEXT NOT NULL);";
            createGenreTable.ExecuteNonQuery();
            
            SQLiteCommand createAlbumTable = connection.CreateCommand();
            createAlbumTable.CommandText = "CREATE TABLE IF NOT EXISTS `album` (`album_id` INTEGER PRIMARY KEY AUTOINCREMENT, `album_name` TEXT NOT NULL);";//"CREATE TABLE IF NOT EXISTS `album` (`album_id`	INTEGER PRIMARY KEY AUTOINCREMENT, `album_name` TEXT NOT NULL, `artist_id`	INTEGER, FOREIGN KEY (artist_id) REFERENCES artist (artist_id), `album_year` INTEGER, `genre_id` INTEGER, FOREIGN KEY (genre_id) REFERENCES genre (genre_id));";
            createAlbumTable.ExecuteNonQuery();

            SQLiteCommand createArtistAlbumsTable = connection.CreateCommand();
            createArtistAlbumsTable.CommandText = "CREATE TABLE IF NOT EXISTS `artist_albums` (`artist_id` INTEGER, `album_id` INTEGER, PRIMARY KEY(artist_id, album_id), FOREIGN KEY (album_id) REFERENCES album (album_id), FOREIGN KEY (artist_id) REFERENCES artist (artist_id));";
            createArtistAlbumsTable.ExecuteNonQuery();

            SQLiteCommand createTrackTable = connection.CreateCommand();
            createTrackTable.CommandText = "CREATE TABLE IF NOT EXISTS `track` (`track_id` INTEGER PRIMARY KEY AUTOINCREMENT, `track_name` TEXT NOT NULL, `artist_id` INTEGER, `track_path` TEXT, `album_id` INTEGER, track_year INTEGER, genre_id INTEGER, FOREIGN KEY (album_id) REFERENCES album (album_id), FOREIGN KEY (artist_id) REFERENCES artist (artist_id), FOREIGN KEY(`genre_id`) REFERENCES genre ( genre_id ));";
            createTrackTable.ExecuteNonQuery();
            
            connection.Close();
        }

        private void loadArtists_Click(object sender, EventArgs e)
        {
            String request = "select artist.artist_name, count(album.album_id) as 'albums_count' " + 
                             "from artist, artist_albums, album " +
                             "where album.album_id = artist_albums.album_id and artist_albums.artist_id = artist.artist_id " +
                             "group by artist.artist_id order by 2 desc;";
            fillDataGrid(request);
        }

        private void loadAlbums_Click(object sender, EventArgs e)
        {
            String request = "select album.album_name, count(track.track_id) as 'tracks_count' " +
                             "from album, track " +
                             "where album.album_id = track.album_id " +
                             "group by album.album_id order by 2 desc;";
            fillDataGrid(request);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (dataGridView1.Columns["Play"] != null && e.ColumnIndex == dataGridView1.Columns["Play"].Index)
                {
                    if (dataGridView1.Columns.Contains("track_path"))
                    {

                        String trackPath = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["track_path"].Index].FormattedValue.ToString();

                        String artistName = "";
                        String trackName = "";
                        playingTrackName = "";

                        if (dataGridView1.Columns.Contains("artist_name"))
                        {
                            artistName = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["artist_name"].Index].FormattedValue.ToString();
                            playingTrackName = artistName + " - ";
                        }

                        if (dataGridView1.Columns.Contains("track_name"))
                        {
                            trackName = dataGridView1.Rows[e.RowIndex].Cells[dataGridView1.Columns["track_name"].Index].FormattedValue.ToString();
                            playingTrackName += trackName;
                        }

                        if (wmp.URL.Equals(trackPath))
                        {
                            if (wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
                            {
                                wmp.controls.pause();
                                playerLabel.Text = "Paused";
                                playerPauseButton.Text = "Play";
                            }
                            else
                            {
                                wmp.controls.play();
                                playerLabel.Text = "Playing";
                                playerPauseButton.Text = "Pause";
                            }
                        }
                        else
                        {
                            wmp.URL = trackPath;
                            initPlayer();
                            playingTrackName = "    " + playingTrackName + "    ";
                            iScroll = 0;
                        }
                    }
                }
            }
        }

        private List<DataGridCell> selectedCells = new List<DataGridCell>();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                String value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString().Replace("'", "''");
                String column = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                DataGridCell cell = new DataGridCell(e.RowIndex, e.ColumnIndex);
                selectedCells.Add(cell);
                System.Console.WriteLine(value);
                System.Console.WriteLine(column);

                String request = "";

                switch (column)
                {
                    case "artist_name":
                        {
                            request = "select artist.artist_name, album.album_name, count(DISTINCT track.track_id) as 'tracks_count' " +
                                      "from album, track, artist, artist_albums " +
                                      "where artist.artist_name = '" + value + "' and album.album_id = track.album_id and album.album_id = artist_albums.album_id and artist_albums.artist_id = artist.artist_id and track.artist_id = artist.artist_id " +
                                      "group by album.album_id order by 3 desc;";
                            break;
                        }

                    case "album_name":
                        {
                            request = "select artist.artist_name, track.track_name, album.album_name, track.track_year, genre.genre_name, track.track_path " +
                                      "from album, track, artist, genre  " +
                                      "where album.album_name = '" + value + "' and track.album_id = album.album_id and artist.artist_id = track.artist_id and track.genre_id = genre.genre_id " +
                                      "group by track.track_id;";
                            break;
                        }

                    case "track_name":
                        {
                            request = "select artist.artist_name, track.track_name, album.album_name, track.track_year, genre.genre_name, track.track_path " +
                                      "from album, track, artist, artist_albums, genre " +
                                      "where track.track_name = '" + value +"' and album.album_id = track.album_id and album.album_id = artist_albums.album_id and artist_albums.artist_id = artist.artist_id and track.artist_id = artist.artist_id and track.genre_id = genre.genre_id " +
                                      "group by album.album_id order by 3 desc;";
                            break;
                        }

                    case "genre_name":
                        {
                            request = "select artist.artist_name, track.track_name, album.album_name, track.track_year, genre.genre_name, track.track_path " +
                                      "from album, track, artist, artist_albums, genre " +
                                      "where genre.genre_name = '" + value + "' and track.genre_id = genre.genre_id and album.album_id = track.album_id and album.album_id = artist_albums.album_id and artist_albums.artist_id = artist.artist_id and track.artist_id = artist.artist_id " +
                                      "group by album.album_id order by 3 desc;";
                            break;
                        }

                    case "track_year":
                        {
                            request = "select artist.artist_name, track.track_name, album.album_name, track.track_year, genre.genre_name, track.track_path " +
                                      "from album, track, artist, artist_albums, genre " +
                                      "where track.track_year = '" + value + "' and album.album_id = track.album_id and album.album_id = artist_albums.album_id and artist_albums.artist_id = artist.artist_id and track.artist_id = artist.artist_id and track.genre_id = genre.genre_id " +
                                      "group by album.album_id order by 3 desc;";
                            break;
                        }

                    case "tracks_count":
                        {
                            String albumName = dataGridView1.Rows[e.RowIndex].Cells["album_name"].FormattedValue.ToString().Replace("'", "''");
                            request = "select artist.artist_name, track.track_name, album.album_name, track.track_year, genre.genre_name, track.track_path " +
                                      "from album, track, artist, genre  " +
                                      "where album.album_name = '" + albumName + "' and track.album_id = album.album_id and artist.artist_id = track.artist_id and track.genre_id = genre.genre_id " +
                                      "group by track.track_id;";
                            break;
                        }

                    case "albums_count":
                        {
                            String artistName = dataGridView1.Rows[e.RowIndex].Cells["artist_name"].FormattedValue.ToString().Replace("'", "''");
                            request = "select artist.artist_name, album.album_name, count(DISTINCT track.track_id) as 'tracks_count' " +
                                      "from album, track, artist, artist_albums " +
                                      "where artist.artist_name = '" + artistName + "' and album.album_id = track.album_id and album.album_id = artist_albums.album_id and artist_albums.artist_id = artist.artist_id and track.artist_id = artist.artist_id " +
                                      "group by album.album_id order by 3 desc;";
                            break;
                        }

                    case "track_path":
                        {
                            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", value));
                            break;
                        }
                }

                fillDataGrid(request);
            }
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            dataGridView1.Focus();
        }

        private void loadAll_Click(object sender, EventArgs e)
        {
            String request = "select artist.artist_name, track.track_name, album.album_name, track.track_year, genre.genre_name, track.track_path " + 
                             "from artist, track, album, genre " +
                             "where track.artist_id = artist.artist_id AND track.album_id = album.album_id AND track.genre_id = genre.genre_id ;";
            fillDataGrid(request);
        }

        private List<DataTable> tables = new List<DataTable>();

        private void fillDataGrid(String request)
        {
            if (String.IsNullOrEmpty(request)) return;

            if (connection == null || connection.State != ConnectionState.Open)
            {
                initDbConnection();
                connection.Open();
            }

            using (SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter(request, connection))
            {
                using (DataTable dataTable = new DataTable())
                {
                    dataGridView1.Columns.Clear();

                    sqlDataAdapter.Fill(dataTable);
                    this.dataGridView1.DataSource = dataTable;
                    if (tables.Count == 1) backButton.Enabled = true;
                    tables.Add(dataTable);

                    columnsComboBox.Items.Clear();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        columnsComboBox.Items.Add(column.ColumnName);
                    }
                    columnsComboBox.SelectedIndex = 0;
                    searchBox.Text = "пошук";
   
                    if (dataGridView1.Columns["track_path"] != null)
                    {
                        DataGridViewButtonColumn playButtonColumn = new DataGridViewButtonColumn();
                        playButtonColumn.Name = "Play";
                        playButtonColumn.Text = "Play";
                        playButtonColumn.UseColumnTextForButtonValue = true;

                        if (dataGridView1.Columns["Play"] == null)
                        {
                            dataGridView1.Columns.Insert(0, playButtonColumn);
                        }
                    }
                    else
                    {
                        if (dataGridView1.Columns["Play"] != null)
                        {
                            dataGridView1.Columns.Remove("Play");
                        }
                    }
                }
            }
        }

        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        private void initPlayer()
        {
            if (String.IsNullOrEmpty(wmp.URL)) return;
            wmp.controls.play();

            String tag = "";

            if (pictureBox1.Image != null && pictureBox1.Image.Tag != null)
                tag = pictureBox1.Image.Tag.ToString();
            else
                tag = "";

            if ((String.IsNullOrEmpty(tag)) || (!String.IsNullOrEmpty(tag) && !tag.Equals(wmp.URL.ToString())))
            {
                try
                {
                    TagLib.File tagFile = TagLib.File.Create(wmp.URL);
                    if (tagFile.Tag.Pictures != null && tagFile.Tag.Pictures.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(tagFile.Tag.Pictures[0].Data.Data);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                        pictureBox1.Image = image;
                        pictureBox1.Image.Tag = wmp.URL;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.DefaultPicture;
                        pictureBox1.Image.Tag = null;
                    }
                }
                catch (Exception exc)
                {

                }               
            }

            playTrackBar.Enabled = true;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            playerLabel.Text = "Playing";
            playerPauseButton.Text = "Pause";
        }

        private void playerPauseButton_Click(object sender, EventArgs e)
        {
            if (wmp == null || String.IsNullOrEmpty(wmp.URL)) return;
            if (wmp.playState == WMPPlayState.wmppsPlaying)
            {
                wmp.controls.pause();
                playerLabel.Text = "Paused";
                playerPauseButton.Text = "Play";
            } 
            else
            {
                wmp.controls.play();
                playerLabel.Text = "Playing";
                playerPauseButton.Text = "Pause";
            }
        }

        private void playTrackBar_Scroll(object sender, EventArgs e)
        {
            wmp.controls.currentPosition = playTrackBar.Value;
        }

        private int iScroll = 0;
        private string playingTrackName = "";
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            playTrackBar.Maximum = Convert.ToInt32(wmp.currentMedia.duration);
            playTrackBar.Value = Convert.ToInt32(wmp.controls.currentPosition);

            if (wmp != null)
            {
                int s = (int)wmp.currentMedia.duration;
                int h = s / 3600;
                int m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                playerDuration.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);

                s = (int)wmp.controls.currentPosition;
                h = s / 3600;
                m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                playerPlaytime.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
                
                iScroll+=2;
                if (iScroll >= playingTrackName.Length) iScroll = 0;
                string str = playingTrackName.Substring(iScroll) + playingTrackName.Remove(iScroll); ;
                playerTrackName.Text = str;
            }
            else
            {
                playerPlaytime.Text = "0:00:00";
                playerDuration.Text = "0:00:00";
            }
        }

        private void playerStopButton_Click(object sender, EventArgs e)
        {
            if (wmp != null)
            {
                wmp.controls.stop();
                playerPlaytime.Text = "0:00:00";
                playerDuration.Text = "0:00:00";
                playerLabel.Text = " ";
                playerPauseButton.Text = "Play";
            }
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            wmp.settings.volume = volumeTrackBar.Value;
            volumeLevel.Visible = true;
            volumeLevel.Text = wmp.settings.volume + "%";
        }

        private void volumeTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            volumeLevel.Visible = false;
        }

        private void volumeTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            volumeLevel.Visible = true;
            volumeLevel.Text = wmp.settings.volume + "%";
        }

        private void playTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            double dblValue;
            dblValue = ((double)e.X / (double)playTrackBar.Width) * (playTrackBar.Maximum - playTrackBar.Minimum);
            playTrackBar.Value = Convert.ToInt32(dblValue);
            wmp.controls.currentPosition = playTrackBar.Value;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Equals("пошук")) return;
            try
            {
                String statement = string.Format(" like '%{0}%'", searchBox.Text.Trim().Replace("'", "''"));
                String column = columnsComboBox.SelectedItem.ToString();
                if(column.Contains("year") || column.Contains("count")) column = "Convert(" + column + ", 'System.String')";

                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = column + statement;
            }
            catch (Exception exc) { Console.WriteLine(exc.Message); }
        }

        private void columnsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox_TextChanged(sender, e);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                DialogResult result = MessageBox.Show("Додати аудіофайли до фонотеки?", "Увага!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    openFolderButton.PerformClick();
                    parseButton.PerformClick();
                }
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = "";
            searchBox.ForeColor = SystemColors.WindowText;
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "пошук";
                searchBox.ForeColor = SystemColors.InactiveCaptionText;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (tables.Count > 1) //2 таблиці, або більше
            {
                try
                {
                    tables.RemoveAt(tables.Count - 1); //прибираємо поточну табоицю (та що зараз на екрані)
                    DataTable dataTable = tables[tables.Count - 1]; //показуємо попередню таблицю
                    dataGridView1.Columns.Clear();
                    this.dataGridView1.DataSource = dataTable;

                    columnsComboBox.Items.Clear();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        columnsComboBox.Items.Add(column.ColumnName);
                    }
                    columnsComboBox.SelectedIndex = 0;
                    searchBox.Text = "пошук";

                    if (dataGridView1.Columns["track_path"] != null)
                    {
                        DataGridViewButtonColumn playButtonColumn = new DataGridViewButtonColumn();
                        playButtonColumn.Name = "Play";
                        playButtonColumn.Text = "Play";
                        playButtonColumn.UseColumnTextForButtonValue = true;

                        if (dataGridView1.Columns["Play"] == null)
                        {
                            dataGridView1.Columns.Insert(0, playButtonColumn);
                        }
                    }

                    if (selectedCells.Count > 0)
                    {
                        DataGridCell cell = selectedCells[selectedCells.Count - 1];
                        selectedCells.RemoveAt(selectedCells.Count - 1);
                        dataGridView1.CurrentCell = dataGridView1.Rows[cell.RowNumber].Cells[cell.ColumnNumber];
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

                if(tables.Count == 1) backButton.Enabled = false;
            }
            else backButton.Enabled = false;  
        }

    }

}
