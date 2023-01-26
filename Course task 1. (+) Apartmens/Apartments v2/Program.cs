using System;

namespace CSharpCourseJan20
{

    class Aparments
    {
        static bool ApartmentIsIncluded (int sections, int floors, int apartmentsOnFloor, int apartmentNumber)
        {
            return (apartmentNumber <= (sections * floors * apartmentsOnFloor)) && apartmentNumber > 0 ? true : false;
        }

        static int WhatSection (int sections, int floors, int apartmentsOnFloor, int apartmentNumber)
        {
            return Convert.ToInt32(Math.Round((double)apartmentNumber / (floors * apartmentsOnFloor), 0));
        }

        static int WhatFloor(int sections, int floors, int apartmentsOnFloor, int apartmentSection, int apartmentNumber)
        {
            return Convert.ToInt32(((double)apartmentNumber - (apartmentSection - 1) * floors * apartmentsOnFloor) / apartmentsOnFloor);
        }

        static string WereOnFloor (int apartmentsOnFloor, int apartmentNumber)
        {
            switch (apartmentNumber % apartmentsOnFloor)
            {
                case 1:
                    return "слева ближняя";
                case 2:
                    return "слева дальняя";
                case 3:
                    return "справа дальняя";
                case 0:
                    return "справа ближняя";
                default:
                    return "ОШИБКА";
            }
        }

        static void Main()
        {
            int sections;
            int floors;
            int apartmentsOnFloor = 4;
            int apartmentNumber;
            int apartmentSection;
            //int apartmentFloor;

            string choise = " ";

            do
            {
                Console.Write("Введите количество этажей = ");
                floors = Convert.ToInt32(Console.ReadLine());

                if (floors < 1)
                    { 
                        Console.WriteLine("Ошибка. Введенное число должно быть больше 0. Повторите ввод."); 
                    }
            }
            while (floors < 1);

            do
            {
                Console.Write("Введите количество подъездов = ");
                sections = Convert.ToInt32(Console.ReadLine());

                if (sections < 1)
                {
                    Console.WriteLine("Ошибка. Введенное число должно быть больше 0. Повторите ввод.");
                }
            }
            while (sections < 1);
            Console.WriteLine();

            while (!choise.Equals("N"))
            {
                Console.Write("Какую квартиру найти? ");
                apartmentNumber = Convert.ToInt32(Console.ReadLine());

                if (ApartmentIsIncluded(sections, floors, apartmentsOnFloor, apartmentNumber))
                {
                    apartmentSection = WhatSection(sections, floors, apartmentsOnFloor, apartmentNumber);

                    //apartmentFloor = WhatFloor(sections, floors, apartmentsOnFloor, apartmentSection, apartmentNumber);



                    Console.WriteLine(  "Квартира №" + apartmentNumber +
                                        " находится в подъезде " + apartmentSection +
                                        " на этаже " + WhatFloor(sections, floors, apartmentsOnFloor, apartmentSection, apartmentNumber) +
                                        " и она " + WereOnFloor(apartmentsOnFloor, apartmentNumber));

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Квартиры №{0} нет в доме", apartmentNumber);
                }

                Console.WriteLine("Найти еще квартиру? (Y/N)");
                choise = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
