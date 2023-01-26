using System;

namespace Apartments
{
    class Apartments
    {
        static string GetApartmentPosition(int apartmentsCountOnFloor, int apartmentNumber)
        {
            switch (apartmentNumber % apartmentsCountOnFloor)
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
            int floorsCount;

            do
            {
                Console.Write("Введите количество этажей: ");
                floorsCount = Convert.ToInt32(Console.ReadLine());

                if (floorsCount < 1)
                {
                    Console.WriteLine("Ошибка. Введенное число должно быть больше 0. Повторите ввод.");
                }
            } while (floorsCount < 1);

            int sectionsCount;

            do
            {
                Console.Write("Введите количество подъездов: ");
                sectionsCount = Convert.ToInt32(Console.ReadLine());

                if (sectionsCount < 1)
                {
                    Console.WriteLine("Ошибка. Введенное число должно быть больше 0. Повторите ввод.");
                }
            }
            while (sectionsCount < 1);

            Console.WriteLine();

            string userChoice = "";

            while (!userChoice.Equals("N") && !userChoice.Equals("n"))
            {
                Console.Write("Введите номер квартиры: ");
                int apartmentNumber = Convert.ToInt32(Console.ReadLine());

                int apartmentsCountOnFloor = 4;

                if (apartmentNumber > sectionsCount * floorsCount * apartmentsCountOnFloor || apartmentNumber <= 0)
                {
                    Console.WriteLine("Квартиры №{0} нет в доме", apartmentNumber);
                }
                else
                {
                    int sectionNumber = (apartmentNumber - 1) / (floorsCount * apartmentsCountOnFloor) + 1;

                    int floorNumber = (apartmentNumber - 1) / apartmentsCountOnFloor % floorsCount + 1;

                    Console.Write("Квартира №" + apartmentNumber);
                    Console.Write(" находится в подъезде " + sectionNumber);
                    Console.Write(" на этаже " + floorNumber);
                    Console.Write(" и она " + GetApartmentPosition(apartmentsCountOnFloor, apartmentNumber));
                    Console.WriteLine();
                }

                Console.WriteLine("Найти еще квартиру? (Y/N)");
                userChoice = Console.ReadLine();
            }
        }
    }
}