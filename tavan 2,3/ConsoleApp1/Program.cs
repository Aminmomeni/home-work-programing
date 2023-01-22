using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int num = Convert.ToInt32(x);
            mohasebe(num);
        }
        private static void mohasebe(int x)
        {
            double z = Math.Pow(x, 2);
            double y = Math.Pow(x, 3);
            Console.WriteLine("tavan 2 barabar ast ba : "+z);
            Console.WriteLine("tavan 3 barabar ast ba : " + y);
            Console.ReadKey();
        }
    }
}
