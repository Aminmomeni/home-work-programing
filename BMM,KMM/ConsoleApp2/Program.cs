using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Kmm(num1, num2);
        }
        public static void Kmm(double num1,double num2)
        {
            double bmm = BMM(x, y);
            double k = (num1 * num2) / bmm;
            Console.WriteLine(k);
            Console.WriteLine(bmm);
        }
        public static void BMM(double num1, double num2)
        {
            double t = 0;
            if (num2 > num1)
            {
                t = num1;
                num1 = num2;
                num2 = t;
            }
            while (true)
            {
                if (num2 == 0) break;
                double temp = num1 % num2;
                num1 = num2;
                num2 = temp;
                return num1;
            }
        }
    }
}
