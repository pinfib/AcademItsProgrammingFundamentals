using System;

namespace Academits.Dorosh
{
    class TaskPrintAndRead
    {
        public static int PrintAndRead(string message)
        {
            Console.Write(message);

            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main()
        {
            int a = PrintAndRead("Введите число A: ");
            int b = PrintAndRead("Введите число B: ");
            int c = PrintAndRead("Введите число C: ");

            Console.WriteLine("Вы ввели: А = {0}, B = {1}, C = {2}", a, b, c);

            Console.ReadKey();
        }
    }
}