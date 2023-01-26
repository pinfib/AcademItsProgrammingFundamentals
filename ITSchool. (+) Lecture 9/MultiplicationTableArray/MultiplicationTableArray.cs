using System;

namespace Academits.Dorosh
{
    class MultiplicationTableArray
    {
        public static int[,] GetMultiplicationTable(int columns, int rows)
        {
            int[,] multiplicationTable = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            return multiplicationTable;
        }

        public static void PrintMultiplicationTable(int[,] array)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("     ");

            int columns = array.GetLength(1);

            for (int i = 1; i <= columns; i++)
            {
                Console.Write("{0, 5}", i);
            }

            Console.ResetColor();

            Console.WriteLine();

            int rows = array.GetLength(0);

            for (int i = 0, n = 1; i < rows; i++, n++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write("{0, -5}", n);

                Console.ResetColor();

                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0, 5}", array[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            int columns = 12;
            int rows = 12;

            int[,] multiplicationTable = GetMultiplicationTable(columns, rows);

            PrintMultiplicationTable(multiplicationTable);

            Console.ReadKey();
        }
    }
}