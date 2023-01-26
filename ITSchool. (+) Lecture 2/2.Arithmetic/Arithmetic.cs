using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseJan20
{
    class Arithmetic
    {
        /// <summary>
        /// Класс вычисляет несколько заданных значений.
        /// </summary>
        static void Main()
        {
            /* 
             Сделать по 1 примеру для каждого оператора (+ - * / %) для целых и вещественных чисел.
             Проверить как работает целочисленное и вещественное деление.
            */

            Console.WriteLine("Цель данной задачи - попрактиковаться в вычислении выражений.");

            int a = 7, b = 3;               //Объявление и инициализация переменных

            Console.WriteLine(Environment.NewLine + "Операции с вычислением переменных типа int:");
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
            Console.WriteLine("{0} - {1} = {2}", a, b, (a - b));
            Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));
            Console.WriteLine("{0} / {1} = {2}", a, b, (a / b) + " (Дробная часть всегда отбрасывается для int)");
            Console.WriteLine("{0} % {1} = {2}", a, b, (a % b));

            double c = 7.5, d = 3.1;        //Объявление и инициализация переменных

            Console.WriteLine(Environment.NewLine + "Операции с вычислением переменных типа double:");
            Console.WriteLine("{0} + {1} = {2}", c, d, (c + d));
            Console.WriteLine("{0} - {1} = {2}", c, d, (c - d));
            Console.WriteLine("{0} * {1} = {2}", c, d, (c * d));
            Console.WriteLine("{0} / {1} = {2}", c, d, (c / d) + " (Дробная часть присутствует и вычисляется с точностью 15 знаков после запятой)");
            Console.WriteLine("{0} % {1} = {2}", c, d, (c % d));

           Console.ReadKey();
        }
    }
}
