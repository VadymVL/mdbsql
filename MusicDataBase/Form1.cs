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
            foreach (DirectoryInfo dir in parentDirectory.GetDirectories())
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
                                richTextBox1.AppendText(tagFile.Tag.FirstPerformer + " - " + tagFile.Tag.Title + Environment.NewLine);
                            }

                        }
                    }
                    catch (Exception e)
                    {

                    }
                    
                }

			}
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
                FilesInSubDirectories(folderName);
            }
            else
            {
                ParseAudio(folder);
            }
        }

    }

}
