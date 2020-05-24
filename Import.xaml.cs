using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace уП2V1
{
    /// <summary>
    /// Логика взаимодействия для Import.xaml
    /// </summary>
    public partial class Import : Window
    {
        public Import()
        {
            InitializeComponent();
        }

         УП2Entities test = new УП2Entities ();
        //Подсоединение БД

        private void ChoiceFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "All files|*.*";
            fileDialog.DefaultExt = ".txt";
            Nullable<bool> dialogOK = fileDialog.ShowDialog();

            if (dialogOK == true)
            {
                string sFilenames = "";
                foreach (string sFilename in fileDialog.FileNames)
                {
                    sFilenames += ";" + sFilename;
                }
                sFilenames = sFilenames.Substring(1);
                tbxFiles.Text = sFilenames;
            }
        } /*Поиск файла для импорта*/

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (ImportCB.Text)
                {
                    case "Name_":
                        {
                            var readFile = File.ReadAllText(tbxFiles.Text);
                            string[] splitCSV = readFile.Split('\n');
                            foreach (var row in splitCSV)
                            {
                                if (!string.IsNullOrEmpty(row))
                                {
                                    var cells = row.Split(';');
                                    var table = new Name_
                                    {
                                        F1= Convert.ToInt32(cells[0]),
                                        Название = Convert.ToString(cells[1]),
                                        Класс_ПО = Convert.ToString(cells[2]),
                                        Дата = Convert.ToString(cells[3]),
                                    };

                                    test.Name_.Add(table);
                                    test.SaveChanges();
                                }
                            }
                            break;
                        }
                    case "User":
                        {
                            var readFile = File.ReadAllText(tbxFiles.Text);
                            string[] splitCSV = readFile.Split('\n');
                            foreach (var row in splitCSV)
                            {
                                if (!string.IsNullOrEmpty(row))
                                {
                                    var cells = row.Split(';');
                                    var deal = new User
                                    {
                                        Login = Convert.ToString(cells[0]),
                                        Password = Convert.ToString(cells[1]),
                                        Role = Convert.ToString(cells[2]),
                                    };

                                    test.User.Add(deal);
                                    test.SaveChanges();
                                }
                            }
                            break;
                        }
                } /*Импорт одной из выбранных таблиц*/

            }
            catch
            {
                MessageBox.Show("Проверте путь выбранного файла и таблицу,\nв которую вы собираетесь импортировать данные.\n" +
                  "Или вы уже импортировали эти данные");
            } /*Сообщение пользователю если файл не тот или уже импортирован*/



        }
    }
}