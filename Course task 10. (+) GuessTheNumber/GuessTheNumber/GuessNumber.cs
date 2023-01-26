using System;

namespace Academits.Dorosh
{
    class GuessNumber
    {
        static void Main()
        {
            Random randomNumber = new Random();
            int secretNumber = randomNumber.Next(1, 101);

            int attemptsCount = 1;

            while (true)
            {
                Console.Write("Введите число: ");
                int userAttempt = Convert.ToInt32(Console.ReadLine());

                if (userAttempt == secretNumber)
                {
                    break;
                }

                if (userAttempt > secretNumber)
                {
                    Console.WriteLine("Неверный ответ. Введённое число больше загаданного.");
                }
                else
                {
                    Console.WriteLine("Неверный ответ. Введённое число меньше загаданного.");
                }

                attemptsCount++;
            }

            Console.WriteLine("Вы угадали! Количество попыток: {0}", attemptsCount);

            Console.ReadKey();
        }
    }
}