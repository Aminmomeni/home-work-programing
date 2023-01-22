using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractional_numbers
{
    public class fractional
    {
        private double A;
        private double B;
        private double C;
        private double D;
        public double a
        {
            get { return A; }
            set { A = value; }
        }
        public double b
        {
            get { return B; }
            set { B = value; }
        }
        public double c
        {
            get { return C; }
            set { C = value; }
        }
        private double d
        {
            get { return D; }
            set { D = value; }
        }
        public void calc()
        {

        }
        public bool calc(double A, double B, double C, double D)
        {
            if (D > 0 && B > 0)
            {
                a = A;
                b = B;
                c = C;
                d = D;
                return true;
            }
            else
            {
                Console.WriteLine("Input wrong!");
                return false;
            }
        }
        public double sum()
        {
            double result = (a / b) + (c / d);
            return result;
        }
        public double mines()
        {
            double result = (a / b) - (c / d);
            return result;
        }
        public double multply()
        {
            double result = (a / b) * (c / d);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number for first fractional");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter two number for second fractional");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            fractional frc = new fractional();
            bool flag = frc.calc(num1, num2, num3, num4);
            if (flag)
            {
                double sum = frc.sum();
                Console.WriteLine("sum: "+sum.ToString());
                double mines = frc.mines();
                Console.WriteLine("mines: " + mines.ToString());
                double multply = frc.multply();
                Console.WriteLine("multply: " + multply.ToString());
            }
            else
            {
                Console.WriteLine("Input not correct");
            }
            Console.ReadKey();
        }
    }
}
