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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
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
            double operand1 = Convert.ToDouble(Operand1.Text);
            double operand2 = Convert.ToDouble(Operand2.Text);
            double res;
            string result, sign;
            sign = Znak.Text;
            switch (sign)
            {
                case "+":
                    res = operand1+operand2;
                    result = Convert.ToString(res);
                    Result.Content = result;
                    break;
                case "-":
                    res = operand2-operand1;
                    result = Convert.ToString(res);
                    Result.Content = result;
                    break;
                case "*":
                    res = operand1*operand2;
                    result = Convert.ToString(res);
                    Result.Content = result;
                    break;
                case "/":
                    if (operand2!= 0)
                    {
                        res = operand1 / operand2;
                        result = Convert.ToString(res);
                        Result.Content = result;
                        break;
                    }
                    else
                    {
                        Result.Content = "На ноль делить нельзя ;(";
                        break;
                    }
                case "%":
                    if (operand2 != 0)
                    {
                        res = operand1 % operand2;
                        result = Convert.ToString(res);
                        Result.Content = result;
                        break;
                    }
                    else
                    {
                        Result.Content = "На ноль делить нельзя ;(";
                        break;
                    }
                case "^":
                    res = Math.Pow(operand1, operand2);
                    result = Convert.ToString(res);
                    Result.Content = result;
                    break;
                default:
                    Result.Content = "Упси что-то не так";
                    break;
            }
        }
    }
}
