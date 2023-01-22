using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class trapeze
    {
        private int A;
        private int B;
        private int H;
        public trapeze() { }
        public trapeze(int a,int b,int h)
        {
            A = a;
            B = b;
            H = h;
        }
        public int a
        {
            get { return A; }
            set { A = value; }
        }
        public int b
        {
            get { return B; }
            set { B = value; }
        }
        public int h
        {
            get { return H; }
            set { H = value; }
        }
        public double calcArea()
        {
            return (A + B) * H / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            trapeze trz = new trapeze();
            Console.WriteLine("Enter First number:");
            trz.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            trz.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number:");
            trz.h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masahat Zozanagheh barabar ast ba :");
            Console.WriteLine(trz.calcArea());
            Console.ReadKey();
        }
    }
}
