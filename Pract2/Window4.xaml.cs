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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        string password = "123";
        public Window4()
        {
            InitializeComponent();
        }

        private void returnbutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pw = new MainWindow();
            pw.Show();
            Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string pass = Password.Password;
            if (pass == password)
            {
                Secret.Content = "А тут ничего и не было";
            }
            else
            {
                Secret.Content = "Неправильный пароль, попробуйте ещё раз";
            }
        }
    }
}
