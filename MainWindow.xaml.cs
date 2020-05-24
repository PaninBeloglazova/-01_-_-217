using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace уП2V1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        [System.Obsolete]
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            УП2Entities db = new УП2Entities();

            db.User.Load();


            var user = db.User
                .Where(u => u.Login == loginUser && u.Password == passUser)
                .FirstOrDefault();
            //Подключение к базе данных


            if (user == null)
            {
                MessageBox.Show("Логин или пароль введены неверно!");
            }//Проверка ввода логина и пароля которые не зарегестрированы.
            if (user != null)
            {
                if (user.Role == "Пользователь")
                {
                    ChoseUser choseUser = new ChoseUser();
                    choseUser.Show();
                    Close();

                }//Проверка роли пользователя
                if ( user.Role == "Админ")
                {
                    admin admin = new admin();
                    admin.Show();

                    Close();
                }//Проверка роли администратора

            }//Проверка на наличие пользователя в базе.

        }

        private void Regin_Click(object sender, RoutedEventArgs e)
        {
            Regist regist = new Regist();
            regist.Show();

        }//Переход на окно регистрации.
    }
}