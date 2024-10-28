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

namespace hesapMakinesi_modernGUI_
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        long number1 = 0;
        long number2 = 0;
        string operation = "";

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            numbers.Text = "0";
        }

        private void n1_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = (number1 * 10) + 1;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                numbers.Text = number2.ToString();
            }
        }

        private void n2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                numbers.Text = number2.ToString();
            }
        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                numbers.Text = number2.ToString();
            }
        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                numbers.Text = number2.ToString();
            }
        }

        private void n5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                numbers.Text = number2.ToString();
            }
        }

        private void n6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                numbers.Text = number2.ToString();
            }
        }

        private void n7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                numbers.Text = number2.ToString();
            }
        }

        private void n8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                numbers.Text = number2.ToString();
            }
        }

        private void n9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                numbers.Text = number2.ToString();
            }
        }

        private void n0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                numbers.Text = number2.ToString();
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            numbers.Text = "0";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            numbers.Text = "0";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            numbers.Text = "0";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    numbers.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    numbers.Text = (number1 - number2).ToString();
                    break;
                case "/":
                    numbers.Text = (number1 / number2).ToString();
                    break;
                case "*":
                    numbers.Text = (number1 * number2).ToString();
                    break;
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            numbers.Text = "0";
        }

        private void plusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                numbers.Text = number2.ToString();
            }
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                numbers.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                numbers.Text = number2.ToString();
            }
        }
    }
}
