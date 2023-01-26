using System;

namespace CSharpCourseJan20
{

    class Aparments
    {


        static void Main()
        {
            int floors, sections, apartmentNumber;
            string choise = " ";

            Console.Write("Введите количество этажей = ");
            floors = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество подъездов = ");
            sections = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            House MyHouse = new House(sections, floors);

            while (!choise.Equals("N"))
            {
                Console.Write("Какую квартиру найти? ");
                apartmentNumber = Convert.ToInt32(Console.ReadLine());

                if (MyHouse.IsIncluded(apartmentNumber))
                {
                    int apartmentSection;

                    apartmentSection = MyHouse.WhatSection(apartmentNumber);

                    Console.Write("Квартира №" + apartmentNumber +
                                        " находится в подъезде " + apartmentSection +
                                        " на этаже " + MyHouse.WhatFloor(apartmentSection, apartmentNumber) +
                                        " и она ");

                    MyHouse.WereOnFloor(apartmentNumber);

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
