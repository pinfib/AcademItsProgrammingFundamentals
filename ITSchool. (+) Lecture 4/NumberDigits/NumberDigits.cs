using System;

namespace NumberDigits
{
    class NumberDigits
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int userNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            int maxDigit = 0;
            int allDigitsSum = 0;
            int oddDigitsSum = 0;

            while (userNumber != 0)
            {
                int digit = userNumber % 10;

                userNumber /= 10;

                allDigitsSum += digit;

                if (digit % 2 != 0)
                {
                    oddDigitsSum += digit;
                }

                if (maxDigit < digit)
                {
                    maxDigit = digit;
                }
            }

            Console.WriteLine("Сумма всех цифр числа = {0}", allDigitsSum);
            Console.WriteLine("Сумма только нечетных цифр = {0}", oddDigitsSum);
            Console.WriteLine("Максимальная цифра числа = {0}", maxDigit);

            Console.ReadKey();
        }
    }
}
