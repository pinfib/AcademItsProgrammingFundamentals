using System;

namespace Academits.Dorosh
{
    class MaxSubstring
    {
        public static int GetMaxCharsCount(string stringToCheck)
        {
            if (string.IsNullOrEmpty(stringToCheck))
            {
                return 0;
            }

            stringToCheck = stringToCheck.ToLower();

            int maxCharsCount = 0;
            int charsCount = 1;

            for (int i = 1; i < stringToCheck.Length; i++)
            {
                if (stringToCheck[i] == stringToCheck[i - 1])
                {
                    charsCount++;

                    continue;
                }

                maxCharsCount = Math.Max(charsCount, maxCharsCount);

                charsCount = 1;
            }

            return Math.Max(charsCount, maxCharsCount);
        }

        static void Main()
        {
            Console.Write("Введите строку: ");
            string userString = Console.ReadLine();

            Console.WriteLine("Максимальное количество одинаковых символов в строке: {0}", GetMaxCharsCount(userString));

            Console.ReadKey();
        }
    }
}