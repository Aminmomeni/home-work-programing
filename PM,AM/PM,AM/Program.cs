using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_AM
{
    class Time
    {
        private int Hour;
        private int Minute;
        public int hour
        {
            get { return Hour; }
            set { Hour = value; }
        }
        public int minute
        {
            get { return Minute; }
            set { Minute = value; }
        }
        public Time()
        {

        }
        public Time(int h, int m)
        {
            Hour = h;
            Minute = m;
        }
        public void calc()
        {
            if (Hour <= 24 && Minute <= 59)
            {
                if (Hour <= 12)
                {
                    Console.WriteLine(Hour + ":" + Minute + "AM");
                }
                else if (Hour > 12)
                {
                    Hour = Hour - 12;
                    Console.WriteLine(Hour + ":" + Minute + "PM");
                }              
            }
            else
            {
                Console.WriteLine("Time not correct");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Enter Hour in 24 formated: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Time tm = new Time(hour,minute);
            tm.calc();
            Console.ReadKey();
        }
    }
}
