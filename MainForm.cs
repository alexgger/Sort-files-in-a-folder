using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileSortedApp
{
    public partial class Application : Form
    {
        private static string pathFolder = "C:\\";
        private string filename;

        public Application()
        {
            InitializeComponent();
        }

        private void SelectFolder(object sender, EventArgs e)
        {
            try
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();

                dialog.Title = "Выберите папку в которой будем сортировать файлы";
                dialog.InitialDirectory = pathFolder;
                dialog.IsFolderPicker = true;

                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    pathFolder = dialog.FileName;
                    pathBox.Text = pathFolder;

                    MessageBox.Show($"Вы выбрали папку: {pathFolder}\nКоличество файлов в выбранной папке: {new DirectoryInfo(pathFolder).GetFiles().Length}", "Выбор папки");
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void StartSort(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<string> allfiles = Directory.EnumerateFiles(pathFolder);

                foreach (string pathFile in allfiles)
                {
                    filename = Path.GetFileName(pathFile);
                    var extension = Path.GetExtension(filename);

                    var FoldersPath = pathFolder + @"\" + extension;

                    if (!Directory.Exists(FoldersPath))
                    {
                        Directory.CreateDirectory(FoldersPath);
                    }
                    File.Move(pathFile, pathFolder + $@"\{extension}\" + filename);
                }
                MessageBox.Show("Файлы были отсортированы по папкам!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{filename}: {ex.Message}", "Ошибка");
            }
        }

        private void AuthorClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/alexgger");
        }
    }
}
