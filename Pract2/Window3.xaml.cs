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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void returnbutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(Input.Text);
            if (input <= 14 && input >= 0)
                Result.Content = "[0-14]";
            else if (input >= 15 && input <= 35)
                Result.Content = "[15-35]";
            else if (input >= 36 && input <= 50)
                Result.Content = "[36-50]";
            else if (input >= 51 && input <= 100)
                Result.Content = "[51-100]";
            else Result.Content = "Что-то не так";
        }
    }
}
