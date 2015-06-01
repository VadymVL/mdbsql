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

        private String folderName = "";

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                textBox1.Text = folderName;
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
                                textBox2.AppendText(String.IsNullOrEmpty(artist) ? "" : artist + " - " + title + Environment.NewLine);
                            }

                        }
                    }
                    catch (Exception e)
                    {

                    }
                    
                }

			}
		}

        public static string toUtf8(string unknown)
        {
            return new string(unknown.ToCharArray().
                Select(x => ((x + 848) >= 'А' && (x + 848) <= 'ё') ? (char)(x + 848) : x).
                ToArray());
        }

        private String toUTF8(String arg)
        {
            Encoding wind1252 = Encoding.GetEncoding(1252);
            Encoding utf8 = Encoding.UTF8;
            byte[] wind1252Bytes = Encoding.Default.GetBytes(arg);
            byte[] utf8Bytes = Encoding.Convert(wind1252, utf8, wind1252Bytes);
            String result = Encoding.UTF8.GetString(utf8Bytes);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo(folderName);
            if(folder.Exists == false)
            {
                MessageBox.Show("Alert!","Directory doesn't exist!");
                return;
            }


            if (checkBox1.Checked) //subdirectories
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
