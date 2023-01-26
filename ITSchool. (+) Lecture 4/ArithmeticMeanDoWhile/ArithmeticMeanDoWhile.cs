using System;

namespace ArithmeticMeanDoWhile
{
    class ArithmeticMeanDoWhile
    {
        static void Main()
        {
            bool isSuccessReading;

            int start;
            int end;

            do
            {
                Console.Write("Введите первое число диапазона: ");
                start = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите последнее число диапазона: ");
                end = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (start < 2)
                {
                    isSuccessReading = false;

                    Console.WriteLine("Диапазон задан неверно: числа должны быть больше 1");
                }
                else if (start >= end)
                {
                    isSuccessReading = false;

                    Console.WriteLine("Диапазон задан неверно: первое число больше или равно второму.");
                }
                else
                {
                    isSuccessReading = true;
                }
            }
            while (!isSuccessReading);

            int allNumbersCount = 0;
            int evenNumbersCount = 0;

            int allNumbersSum = 0;
            int evenNumbersSum = 0;

            int i = start;

            do
            {
                allNumbersCount++;
                allNumbersSum += i;

                if (i % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += i;
                }

                i++;
            }
            while (i <= end);

            double allArithmeticMean = (double)allNumbersSum / allNumbersCount;
            Console.WriteLine("Среднее арифметическое от {0} до {1} = {2:#0.####}", start, end, allArithmeticMean);

            double evenArithmeticMean = (double)evenNumbersSum / evenNumbersCount;
            Console.WriteLine("Среднее арифметическое только чётных чисел диапазона = {0:#0.####}", evenArithmeticMean);

            Console.ReadKey();
        }
    }
}
