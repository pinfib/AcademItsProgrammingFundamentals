using System;

namespace CSharpCourseJan20
{
    class Program
    {
        private static Date GetCurrentDate(string userLine)
        {
            char[] charSeparators = { ' ' };
            string[] dateParts = userLine.Split(charSeparators);

            try
            {
                Date currentDate = new Date(Convert.ToInt32(dateParts[0]), Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[2]));

                if (currentDate.Day != Convert.ToInt32(dateParts[0]))
                {
                    Console.WriteLine("День введен с ошибкой. Установлено значение по умолчанию.");
                }

                if (currentDate.Month != Convert.ToInt32(dateParts[1]))
                {
                    Console.WriteLine("Месяц введен с ошибкой. Установлено значение по умолчанию.");
                }

                if (currentDate.Year != Convert.ToInt32(dateParts[2]))
                {
                    Console.WriteLine("Год введен с ошибкой. Установлено значение по умолчанию.");
                }

                return currentDate;
            }
            catch
            {
                Console.WriteLine("Ошибка ввода. Установлена дата по умолчанию");
                return new Date();
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите день, месяц и год через пробел: ");
            Date currentDate = GetCurrentDate(Console.ReadLine());

            Date nextDate = currentDate.GetNextDate();

            Console.WriteLine("Вы ввели: " + currentDate.GetDateString() + ". Cледующая дата: " + nextDate.GetDateString());

            Console.ReadLine();
        }
    }
}
