using System;

namespace Academits.Dorosh
{
    class SplitString
    {
        public static int[] GetIntArray(string str)
        {
            string[] separators = { ", " };
            string[] substrings = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int[] array = new int[substrings.Length];

            for (int i = 0; i < substrings.Length; i++)
            {
                array[i] = Convert.ToInt32(substrings[i]);
            }

            return array;
        }

        static void Main()
        {
            string stringExample = "1, 5, 1, 5";

            int[] array = GetIntArray(stringExample);

            int sum = 0;

            foreach (int e in array)
            {
                Console.WriteLine("Извлечено число: {0}", e);

                sum += e;
            }

            Console.WriteLine("Сумма чисел в строке: {0}", sum);

            Console.ReadKey();
        }
    }
}