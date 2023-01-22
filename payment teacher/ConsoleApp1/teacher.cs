using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class teacher
    {
        private string ID;
        private string Name;
        private string Family;
        private int Time;
        private int payoneHour;
        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string family
        {
            get { return Family; }
            set { Family = value; }
        }
        public int time
        {
            get { return Time; }
            set
            {
                if (value > 0)
                {
                    Time = value;
                }
                else
                { Time = 0; }
            }
        }
        public int payonehour
        {
            get { return payoneHour; }
            set
            {
                if (value > 0)
                {
                    payoneHour = value;
                }
                else { payoneHour = 0; }
            }
        }
        public teacher()
        {
        }
        public teacher(string Idd,string Namee, string famiily, int hourr, int payy)
        {
            Idd = Id;
            Namee = name;
            famiily = family;
            hourr = time;
            payy = payonehour;
        }
        public long payment()
        {
            return Time * payoneHour;
        }
    }
}
