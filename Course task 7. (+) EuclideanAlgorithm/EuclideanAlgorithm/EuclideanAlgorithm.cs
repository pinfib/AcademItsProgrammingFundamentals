using System;

namespace Academits.Dorosh
{
    class EuclideanAlgorithm
    {
        public static int GetGreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            while (a % b != 0)
            {
                int c = a;
                a = b;
                b = c % b;
            }

            return b;
        }

        static void Main()
        {
            int a;
            int b;

            while (true)
            {
                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());

                if (a != 0 || b != 0)
                {
                    break;
                }

                Console.WriteLine("Ошибка! Числа не должны быть одновременно равны нулю!");
            }

            Console.WriteLine("Наибольший общий делитель: {0}", GetGreatestCommonDivisor(a, b));

            Console.ReadKey();
        }
    }
}