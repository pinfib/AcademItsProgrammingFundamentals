using System;

namespace Academits.Dorosh
{
    class MultiplicationTable
    {
        public static void PrintMultiplicationTable(int start, int end)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("     ");                         //Шапка

            for (int i = start; i <= end; i++)
            {
                Console.Write("{0, 5}", i);
            }

            Console.ResetColor();

            Console.WriteLine();

            for (int i = 1; i <= end; i++)                  //Таблица
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write("{0, 5}", i);

                Console.ResetColor();

                for (int j = start; j <= end; j++)
                {
                    Console.Write("{0, 5}", j * i);
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.WriteLine("1. Вывести таблицу умножения от 1 до 10.");
            Console.WriteLine("2. Ввести свои границы.");
            Console.Write("Выберите вариант: ");

            int userChoice;

            while (true)
            {
                userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == 1 || userChoice == 2)
                {
                    break;
                }

                Console.Write("Ошибка! Такого варианта нет. Повторите ввод: ");
            }

            Console.WriteLine();

            if (userChoice == 1)
            {
                PrintMultiplicationTable(1, 10);
            }
            else
            {
                int end;

                while (true)
                {
                    Console.Write("Введите конечное число: ");
                    end = Convert.ToInt32(Console.ReadLine());

                    if (end > 1)
                    {
                        break;
                    }

                    Console.WriteLine("Ошибка! Введенное число должно быть больше 1.");
                }

                PrintMultiplicationTable(1, end);
            }

            Console.ReadKey();
        }
    }
}