using System;

namespace Academits.Dorosh
{
    class QuickSort
    {
        public static void Sort(int[] array, int left, int right)
        {
            if (right - left < 1)
            {
                return;
            }

            int i = left;
            int j = right;
            int x = array[left];

            while (i <= j)
            {
                while (array[i] < x)
                {
                    i++;
                }

                while (array[j] > x)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            if (i < right)
            {
                Sort(array, i, right);
            }

            if (j > left)
            {
                Sort(array, left, j);
            }
        }

        static void Main()
        {
            int[] arrayExample = { 8, 0, 5, 7, 9, 10, 6, 1, 6, 1, 0 };
            //int[] arrayExample = { };

            Console.WriteLine("Первоначальный массив: {0}", string.Join(" ", arrayExample));

            Sort(arrayExample, 0, arrayExample.Length - 1);

            Console.WriteLine("Отсортированный массив: {0}", string.Join(" ", arrayExample));

            Console.ReadKey();
        }
    }
}