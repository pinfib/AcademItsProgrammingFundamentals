using System;

namespace Academits.Dorosh
{
    class Exponentiate
    {
        public static int GetExponentValue()
        {
            while (true)
            {
                Console.Write("Введите желаемую степень: ");
                int exponent = Convert.ToInt32(Console.ReadLine());

                if (exponent >= 0)
                {
                    return exponent;
                }

                Console.WriteLine("Ошибка! Степень должна быть больше или равна нулю.");
            }
        }

        public static double ExponentiateRecursion(double number, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            return number * ExponentiateRecursion(number, exponent - 1);
        }

        public static double ExponentiateCycle(double number, int exponent)
        {
            double result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= number;
            }

            return result;
        }

        static void Main()
        {
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());

            int exponent = GetExponentValue();

            Console.WriteLine("Возведение в степень при помощи рекурсии: {0:0.###}", ExponentiateRecursion(number, exponent));
            Console.WriteLine("Возведение в степень при помощи цикла: {0:0.###}", ExponentiateCycle(number, exponent));
            Console.WriteLine("Проверка при помощи Math: {0:0.###}", Math.Pow(number, exponent));

            Console.ReadKey();
        }
    }
}