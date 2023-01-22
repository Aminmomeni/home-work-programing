using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risheh_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            calcfun(num1, num2, num3);
            Console.ReadKey();
        }
        private static void calcfun(int a,int b,int c)
        {
            int delta = (b * b) - 4 * (a * c);
            Console.WriteLine("delta barabar ast ba: " + delta);
            if (delta > 0)
            {
                double x1 = (((-1 * b) + Math.Sqrt(delta)) / (2 * a));
                double x2 = (((-1 * b) - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("risheh mosbat: " + x1);
                Console.WriteLine("risheh manfi: " + x2);
            }
            else if (delta == 0)
            {
                double x3 = ((-1 * b) / (2 * a));
                Console.WriteLine("moadeleh daraye rishe mozaaf mibashad: " + x3);
            }
            else
            {
                Console.WriteLine("Risheh Nadarad");
            }
        }
    }
}
