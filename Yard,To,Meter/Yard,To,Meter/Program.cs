using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yard_To_Meter
{
    class yard
    {
        private double Diameter;
        public double diameter
        {
            get { return Diameter; }
            set { Diameter = value; }
        }
        public yard() { }
        public yard(double d)
        {
            this.Diameter = d;
        }
        public double conv()
        {
            return Diameter / 1.198;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number for convert Meter to Yard: ");
            double num = Convert.ToDouble(Console.ReadLine());
            yard yrd = new yard(num);
            double con = yrd.conv();
            Console.WriteLine(con);
            Console.ReadKey();
        }
    }
}
