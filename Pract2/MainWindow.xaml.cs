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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pract2
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

        private void Translate_Click(object sender, RoutedEventArgs e)
        {
            Window1 pw = new Window1();
            pw.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 pw = new Window2();
            pw.Show();
            Close();
        }

        private void Interval_Click(object sender, RoutedEventArgs e)
        {
            Window3 pw = new Window3();
            pw.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 pw = new Window4();
            pw.Show();
            Close();
        }
    }
}
