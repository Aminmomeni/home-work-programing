using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tax_salary
{
    public class test
    {
        private string ID;
        private string Name;
        private string Date;
        private double Money;
        public string id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string date
        {
            get { return Date; }
            set { Date = value; }
        }
        public double MOney
        {
            get { return Money; }
            set { Money = value; }
        }
        public void Test()
        {

        }
        public void Test(string Id, string NAME, string DATE, double MONEY)
        {
            ID = Id;
            Name = NAME;
            Date = DATE;
            Money = MONEY;
        }
        public double Bimeh()
        {
            return (Money * 7 / 100);
        }
        public double Task()
        {
            if (Money >= 6500000)
            {
                return (Money * 10 / 100);
            }
            else
            {
                return (Money * 0);
            }
        }
        public double money()
        {
            return (Money - (Task() + Bimeh()));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            test tst = new test();
            Console.WriteLine("Enter ID");
            string Id = Console.ReadLine();
            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Date");
            string Date = Console.ReadLine();
            Console.WriteLine("Enter salary");
            double Money = Convert.ToDouble(Console.ReadLine());
            tst.Test(Id, Name, Date, Money);
            Console.WriteLine("person id: " + tst.id+"\r\n" + "person name: " + tst.name+"\r\n" + "date: " + tst.date+"\r\n");
            Console.WriteLine("bimeh: " + tst.Bimeh());
            Console.WriteLine("Tax: " + tst.Task());
            Console.WriteLine("salary: " + tst.money());
            Console.ReadKey();
        }
    }
}
