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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
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
                }
            }
            else
            {
                MessageBox.Show("Одно из полей вы отсавили пустым");
            }
            
        }
    }
}
