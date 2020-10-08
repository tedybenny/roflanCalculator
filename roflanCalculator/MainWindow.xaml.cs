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

namespace roflanCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Calc cl = new Calc();
        string symbol;

        private void GetSim(object sender, RoutedEventArgs e)
        {

            symbol = Convert.ToString((sender as Button).Content) ;
        }

        

        private void Calculate(object sender, RoutedEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                switch (symbol)
                {
                    case "Сумма":
                        Result.Text = Convert.ToString(cl.sum(num1, num2));
                        break;
                    case "Вычитание":
                        Result.Text = Convert.ToString(cl.minus(num1, num2));
                        break;
                    case "Умножение":
                        Result.Text = Convert.ToString(cl.multi(num1, num2));
                        break;
                    case "Процент":
                        Result.Text = Convert.ToString(cl.percent(num1, num2)) + "%";
                        break;
                    case "Деление":
                        Result.Text = Convert.ToString(cl.devide(num1, num2));
                        break;
                    case "Корень":
                        Result.Text = Convert.ToString(cl.Sqr(num1, num2));
                        break;
                    case "Степень":
                        Result.Text = Convert.ToString(cl.Pow(num1, num2));
                        break;
                    case "Sin":
                        Result.Text = Convert.ToString(cl.Sin(num1));
                        break;
                    case "Cos":
                        Result.Text = Convert.ToString(cl.Cos(num1));
                        break;
                    case "Tan":
                        Result.Text = Convert.ToString(cl.Tan(num1));
                        break;
                    case "Cot":
                        Result.Text = Convert.ToString(cl.Cot(num1));
                        break;
                    case "Sec":
                        Result.Text = Convert.ToString(cl.Sec(num1));
                        break;
                    case "Csc":
                        Result.Text = Convert.ToString(cl.Csc(num1));
                        break;
                    case "Ln":
                        Result.Text = Convert.ToString(cl.Ln(num1));
                        break;
                    case "Lg":
                        Result.Text = Convert.ToString(cl.Lg(num1));
                        break;
                    case "Factorial":
                        Result.Text = Convert.ToString(cl.Factorial(num1));
                        break;
                    case "Abs":
                        Result.Text = Convert.ToString(cl.Abs(num1));
                        break;
                    case "x2":
                        Result.Text = Convert.ToString(cl.x2(num1));
                        break;


                }
            }
            else
            {
                MessageBox.Show("Одно из полей вы отсавили пустым");
            }
            
        }
    }
}
