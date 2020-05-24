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
    /// Логика взаимодействия для DelData.xaml
    /// </summary>
    public partial class DelData : Window
    {
        public DelData()
        {
            InitializeComponent();
        }

        private void DelDate_Click(object sender, RoutedEventArgs e)
        {
            if (DeleteBaseText.Text == "")
            {
                MessageBox.Show("Введите ID названия.");
            } //Проверка на ввод данных
            else
            {
                int ID = Convert.ToInt32(DeleteBaseText.Text); //Подключение к бд
                УП2Entities db = new УП2Entities();
                db.Name_.Load();
                var DellInfo = db.Name_
                        .Where(u => u.F1 == ID)
                        .FirstOrDefault();

                if (DellInfo == null)
                {
                    MessageBox.Show("Данные с таким ID не существуют.");
                } //Проверка на наличие ID в базе
                if (DeleteBaseText.Text != "" && DellInfo != null)
                {
                    db.Name_.Remove(DellInfo);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно удалены.");
                    Close();
                } //Удаление данных по ID, если они существуют.
            }
        }
    }
}
