using System.Linq;
using System.Windows;
using System.Data;
using System.Data.Entity;

namespace уП2V1
{
    /// <summary>
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
        public Regist()
        {
            InitializeComponent();
        }
        private void Зарегистрироваться_Click(object sender, RoutedEventArgs e)
        {
            string NewLogin = Логин.Text;
            string NewPass = Пароль.Text;
            if (Логин.Text == "" || Пароль.Text == "")
            {
                MessageBox.Show("Поля 'Логин','Пароль' обязательны к заполнению!");
            }

            УП2Entities db = new УП2Entities();
            db.User.Load();

            var user = db.User
                .Where(u => u.Login == NewLogin)
                .FirstOrDefault();
            //Загрузка данных из БД

            if (user != null)
            {
                MessageBox.Show("Этот логин уже занят.");
            }//Проверка на наличие уже занятого логина.

            if (Логин.Text == "" || Пароль.Text == "" )
            {
                MessageBox.Show("Поля 'Логин','Пароль' обязательны к заполнению!");
            }  //Проверка на заполнение полей

            if ((user == null) && (Логин.Text != "" && Пароль.Text != ""))
            {
                user = new User();
                user.Login = Логин.Text;
                user.Password = Пароль.Text;
                user.Role = "Пользователь";
                db.User.Add(user);
                db.SaveChanges();
                MessageBox.Show("Регистрация завершена успешно.");
            }//Добавление нового пользователя в БД.
        }
    }
}