using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int minAge = 1;
            int maxAge = 112;

            if (age < minAge)
            {
                Console.WriteLine("Вы слишком малы.");
            }
            else if (age > maxAge)
            {
                Console.WriteLine("Вы слишком стары.");
            }
            else if (age % 10 == 1 && (age % 100 < 10 || age % 100 > 20))
            {
                Console.WriteLine("Вам " + age + " год.");
            }
            else if (age % 10 < 5 && age % 10 > 1 && (age % 100 < 10 || age % 100 > 20))
            {
                Console.WriteLine("Вам " + age + " года.");
            }
            else
            {
                Console.WriteLine("Вам " + age + " лет.");
            }

            Console.ReadKey();
        }
    }
}