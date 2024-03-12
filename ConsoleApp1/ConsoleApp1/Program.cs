using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Привет, создатель, как тебя зовут?");
            string creatorname = Console.ReadLine();
            Console.WriteLine("А как ты назовёшь меня?");
            string botname = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться {creatorname}, меня зовут {botname} - это ты меня так назвал");
        }
    }
}
