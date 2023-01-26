using System;

namespace Greeting
{
    class Greeting
    {
        static void Main()
        {
            Console.WriteLine("Введите ваше имя:");
            string userName = Console.ReadLine();

            Console.WriteLine("Привет, " + userName + "!");

            Console.ReadKey();
        }
    }
}
