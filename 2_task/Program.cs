using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors;
            int sections;
            int number;
            string choise = " ";


            Console.Write("Введите желаемое количество этажей = ");
            floors = Convert.ToInt32(Console.ReadLine());               //Отрицательное число и ноль будут заменены на число 1
            Console.Write("Введите желаемое количество подъездов = ");
            sections = Convert.ToInt32(Console.ReadLine());             //Отрицательное число и ноль будут заменены на число 1
            Console.WriteLine();

            House myHouse = new House(floors, sections);
            myHouse.PrintHouse();

            while (!choise.Equals("N"))
            {
                Console.Write("Какую квартиру найти? ");
                number = Convert.ToInt32(Console.ReadLine());
                myHouse.SearchApartment(number);
                Console.WriteLine();

                Console.WriteLine("Найти еще квартиру? (Y/N)");
                choise = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
