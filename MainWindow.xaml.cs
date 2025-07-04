using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace stars_talk
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] signs = {
            "Козерог (22.12-19.01)\nСатурн,Гранат,Целеустремленный",
            "Водолей (20.01-19.02)\nУран,Сапфир,Независимый",
            "Рыбы (20.02-20.03)\nНептун,Лунный камень,Мечтательный",
            "Овен (21.03-20.04)\nМарс,Аметист,Энергичный",
            "Телец(20.04-20.05)\nВенера,Изумруд,Надежный",
            "Близнецы(21.05-20.06)\nМеркурий,Агат,Общительный",
            "Рак(21.06-22.07)\nЛуна,Жемчуг,Чувствительный",
            "Лев(23.07-22.08)\nСолнце,Топаз,Гордый",
            "Дева(23.08-22.09)\nМеркурий,Яшма,Практичный",
            "Весы(23.09-22.10)\nВенера,Опал,Дипломатичный",
            "Скорпион (23.10-21.11)\nПлутон,Аквамарин,Чувственный",
            "Стрелец(22.11-21.12)\nЮпитер,Бирюза,Оптимистичный"
        };

            if (string.IsNullOrEmpty(dateTextBox.Text))
            {
                Result.Text = "Пожалуйста, введите дату.";
                return;
            }

            if (DateTime.TryParseExact(dateTextBox.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                int m = date.Month;
                int d = date.Day;

                Result.Text = signs[
                    (m == 12 && d >= 22) || (m == 1 && d <= 19) ? 0 :
                    (m == 1 && d >= 20) || (m == 2 && d <= 18) ? 1 :
                    (m == 2 && d >= 19) || (m == 3 && d <= 20) ? 2 :
                    (m == 3 && d >= 21) || (m == 4 && d <= 19) ? 3 :
                    (m == 4 && d >= 20) || (m == 5 && d <= 20) ? 4 :
                    (m == 5 && d >= 21) || (m == 6 && d <= 21) ? 5 :
                    (m == 6 && d >= 22) || (m == 7 && d <= 22) ? 6 :
                    (m == 7 && d >= 23) || (m == 8 && d <= 22) ? 7 :
                    (m == 8 && d >= 23) || (m == 9 && d <= 22) ? 8 :
                    (m == 9 && d >= 23) || (m == 10 && d <= 22) ? 9 :
                    (m == 10 && d >= 23) || (m == 11 && d <= 21) ? 10 :
                    (m == 11 && d >= 22) || (m == 12 && d <= 21) ? 11 : 0];
            }
            else
            {
                Result.Text = "Неверный формат даты. Используйте dd.мм.yyyy";
            }
        }
    }
}