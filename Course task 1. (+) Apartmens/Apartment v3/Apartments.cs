using System;

namespace CSharpCourseJan20
{
    internal class Apartments
    {
        private static bool ApartmentIsIncluded(int sections, int floors, int apartmentsOnFloor, int apartmentNumber)
        {
            return apartmentNumber <= sections * floors * apartmentsOnFloor && apartmentNumber > 0;
        }

        private static int WhatSection(int floors, int apartmentsOnFloor, int apartmentNumber)
        {
            int apartmentSection = apartmentNumber / (floors * apartmentsOnFloor);

            if (apartmentNumber % (floors * apartmentsOnFloor) > 0)
            {
                apartmentSection++;
            }

            return apartmentSection;
        }

        private static int WhatFloor(int apartmentSection, int floors, int apartmentsOnFloor, int apartmentNumber)
        {
            int countApartmentsInSection = apartmentNumber - (apartmentSection - 1) * floors * apartmentsOnFloor;

            int apartmentFloor = countApartmentsInSection / apartmentsOnFloor;

            if (countApartmentsInSection % apartmentsOnFloor > 0)
            {
                apartmentFloor++;
            }

            return apartmentFloor;
        }

        private static string WereOnFloor(int apartmentsOnFloor, int apartmentNumber)
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

        private static void Main()
        {
            int sections;
            int floors;
            int apartmentsOnFloor = 4;

            do
            {
                Console.Write("Введите количество этажей = ");
                floors = Convert.ToInt32(Console.ReadLine());

                if (floors < 1)
                {
                    Console.WriteLine("Ошибка. Введенное число должно быть больше 0. Повторите ввод.");
                }
            } while (floors < 1);

            do
            {
                Console.Write("Введите количество подъездов = ");
                sections = Convert.ToInt32(Console.ReadLine());

                if (sections < 1)
                {
                    Console.WriteLine("Ошибка. Введенное число должно быть больше 0. Повторите ввод.");
                }
            } while (sections < 1);

            Console.WriteLine();

            string userChoice = " ";

            while (!userChoice.Equals("N"))
            {
                Console.Write("Какую квартиру найти? ");
                int apartmentNumber = Convert.ToInt32(Console.ReadLine());

                if (ApartmentIsIncluded(sections, floors, apartmentsOnFloor, apartmentNumber))
                {
                    int apartmentSection = WhatSection(floors, apartmentsOnFloor, apartmentNumber);

                    Console.WriteLine("Квартира №" + apartmentNumber +
                                      " находится в подъезде " + apartmentSection +
                                      " на этаже " + WhatFloor(apartmentSection, floors, apartmentsOnFloor, apartmentNumber) +
                                      " и она " + WereOnFloor(apartmentsOnFloor, apartmentNumber));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Квартиры №{0} нет в доме", apartmentNumber);
                }

                Console.WriteLine("Найти еще квартиру? (Y/N)");
                userChoice = Convert.ToString(Console.ReadLine());
            }
        }
    }
}