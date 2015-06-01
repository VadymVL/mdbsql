using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TagLib;

namespace MusicDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Зберігає шлях до обранної папки
        private String folderName = "";

        private void openFolderButton_click(object sender, EventArgs e)
        {
            //Показує діалог вибору папки идля сканування
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                openFolderPathBox.Text = folderName; //Відображаємо цей шлях для користувача
            }
        }

        private void FilesInSubDirectories(string foldPath)
        {
            DirectoryInfo parentDirectory = new DirectoryInfo(foldPath);
            foreach (DirectoryInfo dir in parentDirectory.GetDirectories("*",SearchOption.AllDirectories))
            {
                //Здесь мы вызываем метод удаления ненужных файлов, описанный выше.
                //С той лишь разницей, что в качестве параметра мы теперь передаем не путь до каталога, а объект dir.
                ParseAudio(dir);
            }
        }

		private void ParseAudio(DirectoryInfo dir)
		{
			//Проверяем каждый mp3 файл в директории
			foreach (FileInfo file in dir.GetFiles("*.*"))
			{
                if(TagLib.SupportedMimeType.AllExtensions.Contains(file.Extension.ToLower().Replace(".", ""))) //if media file
                {
                    try
                    {
                        TagLib.File tagFile = TagLib.File.Create(file.FullName);
                        if (TagLib.MediaTypes.Audio == tagFile.Properties.MediaTypes)
                        {
                            if (tagFile.Tag.IsEmpty == false)
                            {
                                //richTextBox1.AppendText(tagFile.Tag.ToString() + Environment.NewLine);
                                String artist = tagFile.Tag.FirstPerformer;
                                artist = toUtf8(artist);
                                String title = tagFile.Tag.Title;
                                title = toUtf8(title);
                                //artist = toUTF8(artist);
                                //artist = Encoding.GetEncoding(1251).GetString(Encoding.GetEncoding(1252).GetBytes(artist));
                                outPutText.AppendText(String.IsNullOrEmpty(artist) ? "" : artist + " - " + title + Environment.NewLine);
                            }

                        }
                    }
                    catch (Exception e)
                    {

                    }
                    
                }

			}
		}

        public string toUtf8(string unknown)
        {
            return new string(unknown.ToCharArray().
                Select(x => ((x + 848) >= 'А' && (x + 848) <= 'ё') ? (char)(x + 848) : x). //Проверяем на кириллицу, и возвращаем utf-8
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


            if (subdirectCheckBox.Checked) //subdirectories
            {
                ParseAudio(folder);
                FilesInSubDirectories(folderName);
            }
            else
            {
                ParseAudio(folder);
            }
        }

    }

}
