using System;

namespace NumbersInStringHard
{
    class NumbersInStringHard
    {
        static void Main()
        {
            Console.Write("Введите начальное число: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное число: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество чисел в строке: ");
            int numbersInRow = Convert.ToInt32(Console.ReadLine());

            int numbersCount = 0;
            int i = start;

            while (i <= end)
            {
                Console.Write(i.ToString().PadLeft(5, ' '));

                numbersCount++;

                if (numbersCount == numbersInRow)
                {
                    Console.WriteLine();

                    numbersCount = 0;
                }

                i++;
            }

            Console.ReadKey();
        }
    }
}