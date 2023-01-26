using System;

namespace _2_task
{
    public class House
    {
        private int _floors;
        public int Floors
        { 
            set
            {
                if (value <= 0)
                {
                    _floors = 1;
                }
                else _floors = value;
            }
            get
            {
                return _floors;
            }

        }

        private int _sections;
        public int Sections
        { 
            set
            {
                if (value <= 0)
                {
                    _sections = 1;
                }
                else _sections = value;
            }
            get
            {
                return _sections;
            }
        }

        private int Apartments
        { get; set; }

        private int[,] _house;

        //Конструктор
        public House(int floors, int sections)
        {
            Apartments = 4;
            this.Floors = floors;
            this.Sections = sections;
            _house = new int[Floors, Sections];

            for (int j = 0; j < Sections; j++)
            {
                for (int i = 0; i < Floors; i++)
                {
                    _house[i, j] = (Apartments * Floors * j) + (Apartments * (i + 1));
                }
            }
        }

        //Вывод на консоль
        public void PrintHouse()
        {
            Console.WriteLine();
            for (int i = Floors - 1; i >= 0; i--)
            {
                for (int j = 0; j < Sections; j++)
                {
                    Console.Write("{0}-{1}\t", (_house[i, j] - (Apartments - 1)), _house[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //Есть ли квартира в доме?
        public bool IsIncluded(int number)
        {
            return (number <= _house[Floors - 1, Sections - 1] & number > 0) ? true : false;
        }

        //Поиск по дому
        private void BinarySearchInHouse (int number, ref int a_section, ref int a_floor)
        {
            //Поиск по левому индексу в диапазоне номеров квартир в подъезде
            int left = 0;
            int right = Sections - 1;

            try
            {
                while (left <= right)
                {
                    a_section = (left + right) / 2;

                    if (number >= _house[0, a_section] - (Apartments - 1) && number <= _house[Floors - 1, a_section]) //Поиск во всем диапазоне квартир в подъезде
                    {
                        break;
                    }
                    else if (number < _house[a_floor, a_section])
                    {
                        right = a_section - 1;
                    }
                    else
                    {
                        left = a_section + 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            //Поиск по правому индексу в диапазоне номеров квартир на этаже
            left = 0;
            right = Floors - 1;

            while (left <= right)
            {
                a_floor = (left + right) / 2;

                if (number >= _house[a_floor, a_section] - (Apartments - 1) && number <= _house[a_floor, a_section]) //Поиск во всем диапазоне квартир на этаже
                {
                    break;
                }
                else if (number < _house[a_floor, a_section])
                {
                    right = a_floor - 1;
                }
                else
                {
                    left = a_floor + 1;
                }
            }


        }

        //Вывод результатов поиска
        public void SearchApartment (int number)
        {
            int pos;
            int a_section = 0;
            int a_floor = 0;

            if (this.IsIncluded(number))
            {
                this.BinarySearchInHouse(number, ref a_section, ref a_floor);
                Console.WriteLine();
                Console.Write("Квартира №{0} находится в подъезде №{1}, на этаже №{2}, ", number, a_section + 1, a_floor + 1);

                pos = _house[a_floor, a_section] - number;

                switch (pos)
                {
                    case 3:
                        Console.Write("слева ближняя");
                        break;
                    case 2:
                        Console.Write("слева дальняя");
                        break;
                    case 1:
                        Console.Write("справа дальняя");
                        break;
                    case 0:
                        Console.Write("справа ближняя");
                        break;
                    default:
                        Console.Write("ОШИБКА");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Квартиры №{0} нет в доме", number);
            }
        }
        
    }
}
