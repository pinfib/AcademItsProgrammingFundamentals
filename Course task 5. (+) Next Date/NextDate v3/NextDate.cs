using System;

namespace Academits.Dorosh
{
    class NextDate
    {
        public static int GetMonth()
        {
            while (true)
            {
                int month = Convert.ToInt32(Console.ReadLine());

                if (month >= 1 && month <= 12)
                {
                    return month;
                }

                Console.Write("Ошибка! Введите число от 1 до 12: ");
            }
        }

        public static int GetDay(int month, int year)
        {
            int daysCountInMonth = GetDaysCountInMonth(month, year);

            while (true)
            {
                int day = Convert.ToInt32(Console.ReadLine());

                if (day >= 1 && day <= daysCountInMonth)
                {
                    return day;
                }

                Console.Write("Ошибка! Введите число от 1 до {0}: ", daysCountInMonth);
            }
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

        static void Main()
        {
            Console.Write("Введите год: ");
            int currentDateYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int currentDateMonth = GetMonth();

            Console.Write("Введите день: ");
            int currentDateDay = GetDay(currentDateMonth, currentDateYear);

            Console.WriteLine("Вы ввели: {0:00}.{1:00}.{2:0000}", currentDateDay, currentDateMonth, currentDateYear);

            int nextDateDay;
            int nextDateMonth = currentDateMonth;
            int nextDateYear = currentDateYear;

            if (currentDateDay < GetDaysCountInMonth(currentDateMonth, currentDateYear))
            {
                nextDateDay = currentDateDay + 1;
            }
            else
            {
                nextDateDay = 1;

                if (currentDateMonth < 12)
                {
                    nextDateMonth = currentDateMonth + 1;
                }
                else
                {
                    nextDateMonth = 1;
                    nextDateYear = currentDateYear + 1;
                }
            }

            Console.WriteLine("Следующая дата: {0:00}.{1:00}.{2:0000}", nextDateDay, nextDateMonth, nextDateYear);

            Console.ReadLine();
        }
    }
}