using System;
using System.Collections.Generic;
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

namespace Pract2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        enum Transate
        {
            Солнце = 0,
            Дождь,
        }
        public Window1()
        {
            InitializeComponent();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            switch (result.Text.ToLower())
            {
                case "солнце":
                    result.Text = "Sun";
                    break;
                case "ветер":
                    result.Text = "Wind";
                    break;
                case "дождь":
                    result.Text = "Rain";
                    break;
                case "град":
                    result.Text = "Hail";
                    break;
                case "ливень":
                    result.Text = "Rainfall";
                    break;
                case "облака":
                    result.Text = "clouds";
                    break;
                case "гроза":
                    result.Text = "Storm";
                    break;
                case "жара":
                    result.Text = "Heat";
                    break;
                case "холод":
                    result.Text = "Cold";
                    break;
                case "туман":
                    result.Text = "Fog";
                    break;
                default:
                    result.Text = "Не знаю, сорянба";
                    break;
            }
        }

        private void returnbutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }
    }
}
