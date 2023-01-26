using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Введите индекс числа Фибоначчи: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index < 0)
            {
                Console.WriteLine("Ошибка! Индекс не должен быть отрицательным.");
            }
            else if (index == 0)
            {
                Console.WriteLine("Число Фибоначчи = 0");
            }
            else
            {
                int previousNumber = 0;
                int currentNumber = 1;

                for (int i = 2; i <= index; i++)
                {
                    int temporaryNumber = currentNumber;
                    currentNumber += previousNumber;
                    previousNumber = temporaryNumber;
                }

                Console.WriteLine("Число Фибоначчи = " + currentNumber);
            }

            Console.ReadKey();
        }
    }
}