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

    }
}
