using System;

namespace CSharpCourseJan20
{
    internal class CreateProject
    {
        private static void Main()
        {

            Console.WriteLine("Данная программа вычисляет сумму чисел, расположенных между 1 и N включительно.");

            int n;

            do
            {
                Console.Write("Введите число N = ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Ошибка. Введенное число должно быть больше 0. Повторите ввод.");
                }

            } while (n <= 0);

            int total = 0;

            for (int i = 0; i <= n; i++)
            {
                total += i;
            }

            Console.WriteLine("Сумма чисел между 1 и " + n + " равна " + total);

            Console.ReadKey();
        }
    }
}