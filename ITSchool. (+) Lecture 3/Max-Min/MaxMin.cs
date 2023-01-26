using System;

namespace CSharpCourseJan20
{
    class MaxMin
    {
        static void Main()
        {
            Console.WriteLine("Max/min определяется при помощи тернарного оператора:");

            Console.Write("Введите число A = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = a > b ? a : b;
            int min = a < b ? a : b;

            Console.WriteLine("Большее число = {0}, меньшее = {1}", max, min);
            Console.WriteLine();

            Console.WriteLine("Max/min определяется при помощи if-else:");

            Console.Write("Введите число A = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B = ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }

            Console.WriteLine("Большее число = {0}, меньшее = {1}", max, min);

            Console.ReadKey();
        }
    }
}