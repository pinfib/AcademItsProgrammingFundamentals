using System;

namespace Academits.Dorosh
{
    class ArrayAverage
    {
        public static double GetEvenNumbersAverage(int[] array)
        {
            int evenNumbersSum = 0;
            int evenNumbersCount = 0;

            foreach (int e in array)
            {
                if (e % 2 == 0)
                {
                    evenNumbersSum += e;
                    evenNumbersCount++;
                }
            }

            return (double)evenNumbersSum / evenNumbersCount;
        }

        static void Main()
        {
            int[] arrayExample = { 1, 2, 5, 10, 101, 7 };

            foreach (int e in arrayExample)
            {
                Console.Write(e + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Среднее арифметическое четных чисел в массиве: {0:0.####}", GetEvenNumbersAverage(arrayExample));

            Console.ReadKey();
        }
    }
}