using System;

namespace CSharpCourseJan20
{
    class Password
    {
        static void Main()
        {
            string password = "password123";

            Console.Write("Введите пароль: ");
            string userLine = Console.ReadLine();

            if (userLine.Equals(password))
            {
                Console.WriteLine("Пароль верный.");
            }
            else if (userLine.Length > password.Length)
            {
                Console.WriteLine("Пароли не совпадают. Строка слишком длинная.");
            }
            else if (userLine.Length < password.Length)
            {
                Console.WriteLine("Пароли не совпадают. Строка слишком короткая.");
            }
            else
            {
                Console.WriteLine("Пароли не совпадают.");
            }

            Console.ReadLine();
        }
    }
}