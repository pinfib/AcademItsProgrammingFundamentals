using System;

namespace RowSum
{
    class RowSum
    {
        static void Main()
        {
            Console.Write("Введите количество чисел в выражении: ");
            int numbersCount = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int rowSum = 0;

            while (i <= numbersCount)
            {
                if (i % 2 == 0)
                {
                    rowSum -= (int)Math.Pow(i, 2);
                }
                else
                {
                    rowSum += (int)Math.Pow(i, 2);
                }

                i++;
            }

            Console.WriteLine("Сумма ряда = {0}", rowSum);

            Console.ReadKey();
        }
    }
}
