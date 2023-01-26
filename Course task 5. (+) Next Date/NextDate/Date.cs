namespace CSharpCourseJan20
{
    class Date
    {
        private int day;
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                if (value > 0 && value < 32)
                {
                    day = value;
                }
                else
                {
                    day = 1;
                }
            }
        }

        private int month;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value > 0 && value < 13)
                {
                    month = value;
                }
                else
                {
                    month = 1;

                }
            }
        }

        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    year = value;
                }
                else
                {
                    year = 1;

                }
            }
        }

        public Date()
        {
            Year = 1;
            Month = 1;
            Day = 1;
        }

        public Date(int day, int month, int year)
        {
            Year = year;

            if (month > 12)
            {
                Month = 12;
            }
            else
            {
                Month = month;
            }

            if (day < GetDaysCountInMonth(Month, Year))
            {
                Day = day;
            }
            else
            {
                Day = GetDaysCountInMonth(Month, Year);
            }
        }

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        public int GetDaysCountInMonth(int month, int year)
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
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        return 31;
                }
            }

            return -1;
        }

        public Date GetNextDate()
        {
            Date nextDate = new Date(Day, Month, Year);

            if (Day + 1 <= GetDaysCountInMonth(Month, Year))
            {
                nextDate.Day = this.Day + 1;

            }
            else
            {
                nextDate.Day = 1;

                if (this.Month + 1 <= 12)
                {
                    nextDate.Month = this.Month + 1;
                }
                else
                {
                    nextDate.Month = 1;
                    nextDate.Year = this.Year + 1;
                }
            }

            return nextDate;
        }

        public string GetDateString()
        {
            string separator = ".";

            string dayFormat = "00";
            string monthFormat = "0";
            string yearFormat = "0000";

            return Day.ToString(dayFormat) + separator + Month.ToString(monthFormat) + separator + Year.ToString(yearFormat);
        }
    }
}
