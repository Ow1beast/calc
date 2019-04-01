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

namespace calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Answer.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    Answer.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    Answer.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    Answer.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Answer.Text = number2.ToString();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Answer.Text = number2.ToString();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Answer.Text = number2.ToString();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Answer.Text = number2.ToString();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Answer.Text = number2.ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Answer.Text = number2.ToString();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Answer.Text = number2.ToString();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Answer.Text = number2.ToString();
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Answer.Text = number2.ToString();
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                Answer.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Answer.Text = number2.ToString();
            }
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Answer.Text = "0";
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Answer.Text = "0";
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Answer.Text = "0";
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Answer.Text = "0";
        }
    }
}
