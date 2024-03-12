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
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("ToLocalTime: " + dateTime.ToLocalTime());
            Console.WriteLine("ToUniversalTime: " + dateTime.ToUniversalTime());
            Console.WriteLine("ToLongDateString: " + dateTime.ToLongDateString());
            Console.WriteLine("ToShortDateString: " + dateTime.ToShortDateString());
            Console.WriteLine("ToLongTimeString: " + dateTime.ToLongTimeString());
            Console.WriteLine("ToShortTimeString: " + dateTime.ToShortTimeString());
        }
    }
}
