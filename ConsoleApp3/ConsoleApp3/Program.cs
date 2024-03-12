using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(theRealMain);
            thread.Start();
        }

        static void theRealMain()
        {
            for (int i = 5; i > 0; --i)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
            }

            Console.WriteLine("done.");
        }
    }
}
