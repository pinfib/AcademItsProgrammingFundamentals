using System;

namespace _1_task
{

    class Program
    {
    static void Main(string[] args)
        {
            string choise = " ";

            while (!choise.Equals("N"))
            {
                Console.Write("Введите строку -> ");
                MaxSubstring.str = MaxSubstring.NormalizationString(Console.ReadLine());
                Console.WriteLine("Максимальная подстрока = {0}", MaxSubstring.SearchMaxSubstring(MaxSubstring.str.ToCharArray()));
                Console.WriteLine();

                Console.WriteLine("Еще? (Y/N)");
                choise = Convert.ToString(Console.ReadLine());
                Console.WriteLine(choise);
            }

        }
    }
}
