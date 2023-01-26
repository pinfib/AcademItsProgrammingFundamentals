using System;

namespace Academits.Dorosh
{
    class PrimeNumbers
    {
        public static int GetEndNumber()
        {
            while (true)
            {
                Console.Write("Введите число, до которого будет выводиться ряд простых чисел: ");
                int endNumber = Convert.ToInt32(Console.ReadLine());

                if (endNumber < 2)
                {
                    Console.WriteLine("Ошибка! Число должно быть больше или равно 2.");
                    continue;
                }

                return endNumber;
            }
        }

        static void Main()
        {
            int endNumber = GetEndNumber();

            Console.Write("Простые числа:");

            for (int number = 2; number <= endNumber; number++)
            {
                bool isPrimeNumber = true;

                int maxDivisor = Convert.ToInt32(Math.Sqrt(number));

                for (int divisor = 2; divisor <= maxDivisor; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                if (isPrimeNumber)
                {
                    Console.Write(" {0}", number);
                }
            }

            Console.ReadKey();
        }
    }
}