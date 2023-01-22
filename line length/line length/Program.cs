using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_length
{
    class length
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public double Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public length() { }
        public length(double a, double b, double c, double d)
        {
            x1 = a;
            y1 = b;
            x2 = c;
            y2 = d;
        }
        public double calc()
        {
            double x = Math.Pow(x2 - x1, 2);
            double y = Math.Pow(y2 - y1, 2);
            double sqr = Math.Sqrt(x + y);
            return sqr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            length lng = new length();
            Console.WriteLine("Enter x & y for first point");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x & y for second point");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            lng.X1 = num1;
            lng.Y2 = num2;
            lng.X2 = num3;
            lng.Y2 = num4;
            double result = lng.calc();
            Console.WriteLine("line_length = " + result);
            Console.ReadKey();
        }
    }
}
