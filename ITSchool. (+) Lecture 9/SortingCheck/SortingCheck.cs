using System;

namespace Academits.Dorosh
{
    class SortingCheck
    {
        public static bool IsSortedAscending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsSortedDescending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            int[] arrayExample = { 1, 2, 3, 4, 5 };
            //int[] arrayExample = new int[] { 5, 4, 3, 2, 1 };
            //int[] arrayExample = new int[] { 4, 8, 6, 4, 7 };
            //int[] arrayExample = new int[] { 4, 4, 4, 4, 7 };

            Console.Write("Массив \" ");

            foreach (int e in arrayExample)
            {
                Console.Write(e + " ");
            }

            if (IsSortedAscending(arrayExample))
            {
                Console.Write("\" - сортирован по возрастанию");
            }
            else if (IsSortedDescending(arrayExample))
            {
                Console.Write("\" - сортирован по убыванию");
            }
            else
            {
                Console.Write("\" - не сортирован");
            }

            Console.ReadKey();
        }
    }
}