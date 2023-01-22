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
            teacher th = new teacher();
            th.Id = "123";
            th.name = "ali";
            th.family = "ahmadi";
            th.time = 16;
            th.payonehour = 23000;
            Console.WriteLine("person ID :"+th.Id+ "\r\n"+"person Name :" +th.name + "\r\n"+"person Family :" + th.family+ "\r\n"+"peyment :"+ th.payment()+ "\r\n");
            Console.ReadKey();
        }
    }
}
