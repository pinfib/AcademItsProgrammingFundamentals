using System;

namespace Academits.Dorosh
{
    class SelectionSort
    {
        public static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }

        static void Main()
        {
            int[] arrayExample = { 91, 17, 8, 7, 41, 58, 10, 6, 6, 1, 1 };

            Console.WriteLine("Первоначальный массив: {0}", string.Join(" ", arrayExample));

            SortArray(arrayExample);

            Console.WriteLine("Отсортированный массив: {0}", string.Join(" ", arrayExample));

            Console.ReadKey();
        }
    }
}