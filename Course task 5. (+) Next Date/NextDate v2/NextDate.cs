using System;

namespace Academits.Dorosh
{
    class NextDate
    {
        public static Date GetDate()
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц: ");

            int month;

            while (true)
            {
                month = Convert.ToInt32(Console.ReadLine());

                if (month >= 1 && month <= 12)
                {
                    break;
                }
                else
                {
                    Console.Write("Ошибка! Введите число от 1 до 12: ");
                }
            }

            Console.Write("Введите день: ");

            int day;

            while (true)
            {
                day = Convert.ToInt32(Console.ReadLine());

                if (day >= 1 && day <= GetDaysCountInMonth(month, year))
                {
                    break;
                }
                else
                {
                    Console.Write("Ошибка! Введите число от 1 до {0}: ", GetDaysCountInMonth(month, year));
                }
            }

            return new Date(day, month, year);
        }

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        public static int GetDaysCountInMonth(int month, int year)
        {
            if (month == 2 && IsLeapYear(year))
            {
                return 29;
            }
            else
            {
                switch (month)
                {
                    case 2:
                        return 28;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    default:
                        return 31;
                }
            }
        }

        public static Date GetNextDate(Date currentDate)
        {
            Date nextDate = new Date(currentDate.Day, currentDate.Month, currentDate.Year);

            if (currentDate.Day + 1 <= GetDaysCountInMonth(currentDate.Month, currentDate.Year))
            {
                nextDate.Day = currentDate.Day + 1;
            }
            else
            {
                nextDate.Day = 1;

                if (currentDate.Month + 1 <= 12)
                {
                    nextDate.Month = currentDate.Month + 1;
                }
                else
                {
                    nextDate.Month = 1;
                    nextDate.Year = currentDate.Year + 1;
                }
            }

            return nextDate;
        }

        public static void Main()
        {
            Date currentDate = GetDate();
            Console.WriteLine("Вы ввели: {0:00}.{1:00}.{2:0000}", currentDate.Day, currentDate.Month, currentDate.Year);

            Date nextDate = GetNextDate(currentDate);
            Console.WriteLine("Следующая дата: {0:00}.{1:00}.{2:0000}", nextDate.Day, nextDate.Month, nextDate.Year);

            Console.ReadLine();
        }
    }
}