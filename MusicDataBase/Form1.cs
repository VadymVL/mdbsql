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

namespace MusicDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        //Забезпечує виконання роботи у окремому потоці
        private BackgroundWorker bw;
        //Зберігає шлях до обранного каталогу
        private String folderName = "";
        private int totalFolders = 0;
        private int totalFiles = 0;
        private int songCount = 0;

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
            const string databaseName = @"cyber.db";
            SQLiteConnection connection =
                new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
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
                            {
                                //richTextBox1.AppendText(tagFile.Tag.ToString() + Environment.NewLine);
                                String artist = tagFile.Tag.FirstPerformer;
                                artist = toUtf8(artist);
                                String title = tagFile.Tag.Title;
                                title = toUtf8(title);
                                //artist = toUTF8(artist);
                                //artist = Encoding.GetEncoding(1251).GetString(Encoding.GetEncoding(1252).GetBytes(artist));
                                songName = (String.IsNullOrEmpty(artist) ? "" : artist + " - " + title + Environment.NewLine);
                                //outPutText.AppendText(String.IsNullOrEmpty(artist) ? "" : artist + " - " + title + Environment.NewLine);
                                songCount++;
                                dbInsert("artist", "name", "'" + artist + "'", connection);
                                dbInsert("song", "name", "'" + title + "'", connection);
                            }

                        }
                    }
                    catch (Exception e)
                    {

                    }
                    
                }

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
            transaction.Commit();
            connection.Close();
		}

        public string toUtf8(string unknown) //Конвертуємо усі теги у UTF-8
        {
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

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            //for (int i = 1; (i <= 10); i++)
            //{
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    //break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    //System.Threading.Thread.Sleep(500);
                    DirectoryInfo folder = new DirectoryInfo(folderName);
                    if (subdirectCheckBox.Checked) //subdirectories
                    {
                        ParseAudio(folder);
                        FilesInSubDirectories(folderName);
                    }
                    else
                    {
                        ParseAudio(folder);
                    }
                    //worker.ReportProgress((10));
                    if (worker.CancellationPending == true) //Перевіряємо, чи завдання було відмінено в ході виконання
                    {
                        e.Cancel = true;
                    }
                }
            //}
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
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
            }
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.parsingStatusLabel.Text = (e.ProgressPercentage.ToString() + "%");
            //this.outPutText.AppendText(e.UserState.ToString());
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
        }

        static int counterId = 1;
        private static void dbConnect()
        {
            
            const string databaseName = @"cyber.db";
            SQLiteConnection connection =
                new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'artist' ('id', 'name') VALUES (1, 'Вася');", connection);
            //command.ExecuteNonQuery();
            SQLiteCommand insert = new SQLiteCommand("IF EXISTS (SELECT * FROM 'artist' WHERE 'name'='Вася') " +
                                                      "UPDATE 'artist' SET (...) WHERE Column1='SomeValue' " +
                                                      "ELSE INSERT INTO 'artist' VALUES (...)", connection);

            SQLiteCommand insert2 = new SQLiteCommand("INSERT INTO memos(id,text) " + 
                                                      "SELECT 5, 'text to insert' " +
                                                      "WHERE NOT EXISTS (SELECT 1 FROM memos WHERE id = 5 AND text = 'text to insert');", connection);

            SQLiteCommand insert22 = new SQLiteCommand("INSERT INTO artist(id, name) " +
                                                      "SELECT " + counterId + ", 'Вася' " +
                                                      "WHERE NOT EXISTS (SELECT 1 FROM artist WHERE id = " + counterId + " AND name = 'Вася');", connection);
            insert22.ExecuteNonQuery();

            //SQLiteCommand insert3 = new SQLiteCommand("INSERT INTO " + tableName + " ( " + columns + " ) " + 
             //                                          "SELECT " + values + " " +
             //                                          "WHERE NOT EXISTS (SELECT 1 FROM " + tableName + " WHERE id = 5 AND text = 'text to insert');", connection);
            connection.Close();
            counterId++;
        }

        static SQLiteConnection m_dbConnection;
        public static void Run()
        {
            // http://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/
            // 
            // ### Create the database
            // SQLiteConnection.CreateFile("MyDatabase.sqlite");
 
            // ### Connect to the database
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
 
            // ### Create a table
            // string sql = "CREATE TABLE highscores (name VARCHAR(20), score INT)";
            // SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();
 
            // ### Add some data to the table
            // string sql = "insert into highscores (name, score) values ('Me', 3000)";
            // SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();
            // sql = "insert into highscores (name, score) values ('Myself', 6000)";
            // command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();
            // sql = "insert into highscores (name, score) values ('And I', 9001)";
            // command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();
 
            // ### select the data
            string sql = "select * from highscores order by score desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
 
            Console.ReadKey();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String id = "'"+ numericUpDown1.Text +"'";
            String name = "'" + textBox1.Text + "'";
            String[] columnsArray = new String[] {"id", "name"};
            String[] valuesArray = new String[] { id, name };
            //dbInsert("artist", columnsArray, valuesArray);
            //dbConnect();
        }

        private void dbInsert(String tableName, String columnsString, String valuesString, SQLiteConnection connection/*String[] columnsArray, String[] valuesArray*/)
        {
            //String columnsString = "name";//String.Join(", ", columnsArray);
           // String valuesString = "'" + textBox1.Text + "'";//String.Join(", ", valuesArray);
            
            SQLiteCommand insert22 = new SQLiteCommand("INSERT INTO " + tableName + " ( " + columnsString + " ) " +
                                                       "SELECT " + valuesString + " " +
                                                       "WHERE NOT EXISTS (SELECT 1 FROM " + tableName + " WHERE " + columnsString + " = " + valuesString/* + columnsArray[0] + " = " + valuesArray[0] + " AND " + columnsArray[1] + " = " + valuesArray[1]*/ + " );", connection);
            insert22.ExecuteNonQuery();
            //connection.Close();
          //  List<Object> items;
         //   using (var db = new SQLiteConnection(@"cyber.db"))
          //  {
         //       db.RunInTransaction(() =>
         ////       {
         //           foreach (var item in items)
         //           {
         //               db.Insert(item);
        //            }
        //        });
        //    }
        }


    }

}
