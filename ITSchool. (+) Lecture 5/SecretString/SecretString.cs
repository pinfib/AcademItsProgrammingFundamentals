using System;

namespace SecretString
{
    class SecretString
    {
        static void Main()
        {
            Console.WriteLine("Попробуйте угадать загаданную строку.");

            string secretString = "шесть";

            while (true)
            {
                Console.Write("Введите ваш вариант: ");
                string userString = Console.ReadLine();

                if (userString.Equals(secretString))
                {
                    break;
                }

                Console.WriteLine("Ответ не верный.");
                Console.WriteLine();
            }

            Console.WriteLine("Вы угадали!");

            Console.ReadKey();
        }
    }
}