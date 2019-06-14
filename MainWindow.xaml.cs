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

namespace Calculater
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string left_operand = "";
        string right_operand = "";
        string operat = "";
        bool flag = false;

        public MainWindow()
        {



            InitializeComponent();
        }

        // метод добавления числа к строке чисел и на дисплей
        void add_number(string number)
        {
            display.Text += number;
            if (flag == false)
            {

                left_operand += number;


            }
            else
            {
                right_operand += number;
            }

        }

        // обработчики нажатия на кнопки

        private void btn_1_click(object sender, RoutedEventArgs e)
        {
            add_number("1");


        }

        private void btn_2_click(object sender, RoutedEventArgs e)
        {
            add_number("2");
        }

        private void btn_3_click(object sender, RoutedEventArgs e)
        {
            add_number("3");
        }

        private void btn_4_click(object sender, RoutedEventArgs e)
        {
            add_number("4");
        }


        private void btn_5_click(object sender, RoutedEventArgs e)
        {
            add_number("5");
        }

        private void btn_6_click(object sender, RoutedEventArgs e)
        {
            add_number("6");
        }


        private void btn_7_click(object sender, RoutedEventArgs e)
        {
            add_number("7");
        }
        private void btn_8_click(object sender, RoutedEventArgs e)
        {
            add_number("8");
        }


        private void btn_9_click(object sender, RoutedEventArgs e)
        {
            add_number("9");
        }

        private void btn_0_click(object sender, RoutedEventArgs e)
        {
            add_number("0");
        }

        private void clear_click(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            left_operand = "";
            right_operand = "";
        }

        private void plus_click(object sender, RoutedEventArgs e)
        {
            display.Text += "+";
            flag = true;
            operat = "+";

        }

        private void equal_click(object sender, RoutedEventArgs e)
        {
            display.Text += "=";
            
                 
           double x = double.Parse(left_operand);
            double y=double.Parse(right_operand);

            switch (operat)
            {
                case "+": display.Text = left_operand=(Convert.ToString(x + y)); break;
                case "-": display.Text = left_operand=Convert.ToString(x - y); break;
                case "*": display.Text = left_operand=Convert.ToString(x * y); break;
                case "/": display.Text = left_operand=Convert.ToString(x / y); break;
                default: display.Text = "ERROR!!!!";break;

            }
            operat = "";
            right_operand = "";
            
            flag = false;
            
            

        }

        private void minus_click(object sender, RoutedEventArgs e)
        {
            display.Text += "-";
            flag = true;
            operat = "-";

        }

        private void umn_click(object sender, RoutedEventArgs e)
        {
            display.Text += "*";
            flag = true;
            operat = "*";


        }

        private void del_click(object sender, RoutedEventArgs e)
        {
            display.Text += "/";
            flag = true;
            operat = "/";

        }
    }
}

  
    

