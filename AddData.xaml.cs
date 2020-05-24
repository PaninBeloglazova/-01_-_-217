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
    /// Логика взаимодействия для AddData.xaml
    /// </summary>
    public partial class AddData : Window
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void AddBase_Click(object sender, RoutedEventArgs e)
        {
            if (ID.Text == "" || Название.Text == "" || Класс_ПО.Text == "" || Дата.Text == "")
            {
                MessageBox.Show("Поля 'ID Названия','Название','Класс_ПО','Дата' обязательны к заполнению!");
                Close();
            } //Проверка на заполнение полей
            else
            {
                УП2Entities db = new УП2Entities(); //Подключение к базе данных
                db.Name_.Load();
                int NewID = Convert.ToInt32(ID.Text);
                var NewInfo = db.Name_
                .Where(u => u.F1 == NewID)
                .FirstOrDefault();
                if (NewInfo != null)
                {
                    MessageBox.Show("Данные с таким ID уже существуют.");
                } //Проверка на наличие данных по ID
                if ((NewInfo == null) && (ID.Text != "" && Название.Text != "" && Класс_ПО.Text != "" && Дата.Text != ""))
                {

                    NewID = Convert.ToInt32(ID.Text);
                    string NewName = Название.Text;
                    string Class = Класс_ПО.Text;
                    string NewData = Дата.Text;
                    NewInfo = new Name_();
                    NewInfo.F1 = NewID;
                    NewInfo.Название = NewName;
                    NewInfo.Класс_ПО = Class;
                    NewInfo.Дата = NewData;
                    db.Name_.Add(NewInfo);
                    db.SaveChanges();
                    MessageBox.Show("Новые данные введены успешно.");
                } //Проверка на заполнение полей и добавление данных в бд.
            }
        }
    }
}
