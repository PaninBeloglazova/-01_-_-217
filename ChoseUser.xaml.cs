using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для ChoseUser.xaml
    /// </summary>
    public partial class ChoseUser : Window
    {
        public ChoseUser()
        {
            InitializeComponent();
        }

        private void ОткрытьБазуДанных_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Visibility = Visibility.Visible;
            УП2Entities db = new УП2Entities();
            db.Name_.Load();
            var query =
                from t in db.Name_
                select new { t.F1, t.Название, t.Класс_ПО, t.Дата };
            DataBase.ItemsSource = query.ToList();
        }

        private void Печать_Click(object sender, RoutedEventArgs e)
        {
            Print print = new Print();
            print.Show();
        }
    }
}
