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
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        public admin()
        {
            InitializeComponent();
        }

        private void ОткрытьБазуДанных_Click(object sender, RoutedEventArgs e)
        {
            UsersDataBase.Visibility = Visibility.Collapsed;
            DataBase.Visibility = Visibility.Visible;
            УП2Entities db = new УП2Entities();
            db.Name_.Load();
            var query =
            from t in db.Name_
            select new { t.F1, t.Название, t.Класс_ПО, t.Дата };
            DataBase.ItemsSource = query.ToList();
        }/*Вывод базы данных ПО*/

        private void ЗарегистрироватьПользователя_Click(object sender, RoutedEventArgs e)
        {
            Regist regist = new Regist();
            regist.Show();
        }/*Регистрация нового пользователя*/

        private void ОткрытьБазуПользователей_Click(object sender, RoutedEventArgs e)
        {
            UsersDataBase.Visibility = Visibility.Collapsed;
            DataBase.Visibility = Visibility.Visible;
            УП2Entities db = new УП2Entities();
            db.User.Load();
            var queryUser =
            from s in db.User
            select new { s.Login, s.Password, s.Role };
            DataBase.ItemsSource = queryUser.ToList();
        }/*Вывод базы данных пользователей*/

        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            AddData OpenAddBasePage = new AddData();
            OpenAddBasePage.Show();
        } /*Вывод окна для добавления новой записи в БД ПО*/

        private void DelData_Click(object sender, RoutedEventArgs e)
        {
            DelData DeletePage = new DelData();
            DeletePage.Show();
        } /*Вывод окна для удаления записи в БД ПО*/

        private void импортДанных_Click(object sender, RoutedEventArgs e)
        {
            Import import = new Import();
            import.Show();
        }/*Вывод окна для импорта*/

        private void EditUserInfo_Click(object sender, RoutedEventArgs e)
        {
            EditUserInfo editUserInfo = new EditUserInfo();
            editUserInfo.Show();
        }
    }
}
