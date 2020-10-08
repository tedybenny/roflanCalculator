using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace roflanCalculator
{
    public class Calc
    {
        public int sum(int a,int b)
        {
            return a + b;
        }
        
        public int minus(int a,int b)
        {
            return a - b;
        }

        public int multi(int a,int b)
        {
            return a * b;
        }

        public double percent(double a,double b)
        {
            return ((a / b) * 100);

        }

        public double devide(double a,double b)
        {
            return (a / b);
        }
        public double Sqr(double a,double b)
        {
            return(Math.Pow(a,1/b));
        }
        public double Pow(double a, double b)
        {
            return (Math.Pow(a, b));
        }
        public double Sin(double a)
        {
            return (Math.Sin(a));
        }
        public double Cos(double a)
        {
            return (Math.Cos(a));
        }
        public double Tan(double a)
        {
            return (Math.Tan(a));
        }
        public double Cot(double a)
        {
            return (1 / Math.Tan(a));
        }
        public double Sec(double a)
        {
            return (1 / Math.Cos(a));
        }
        public double Csc(double a)
        {
            return (1 / Math.Sin(a));
        }
        public double Ln(double a)
        {
            return (Math.Log(a,Math.E));
        }
        public double Lg(double a)
        {
            return (Math.Log(a,10));
        }
        public double Factorial(double a)
        {
            int factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        public double Abs(double a)
        {
            return (Math.Abs(a));
        }
        public double x2(double a)
        {
            return (Math.Pow(a,2));
        }

    }
}
