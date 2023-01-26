using System;

namespace CSharpCourseJan20
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 0)
            {
                Console.WriteLine("Ввод неверен.");
            }
            else
            {
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) //Или DateTime.IsLeapYear(year)
                {
                    Console.WriteLine("Год високосный");
                }
                else
                {
                    Console.WriteLine("Год невисокосный");
                }
            }

            Console.ReadLine();
        }
    }
}
