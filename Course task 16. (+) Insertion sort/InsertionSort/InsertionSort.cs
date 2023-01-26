using System;

namespace Academits.Dorosh
{
    class InsertionSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];

                for (int j = i - 1; ; j--)
                {
                    if (j < 0 || temp >= array[j])
                    {
                        array[j + 1] = temp;

                        break;
                    }

                    array[j + 1] = array[j];
                }
            }
        }

        static void Main()
        {
            int[] arrayExample = { 8, 0, 5, 7, 9, 10, 6, 1, 6, 1 };

            Console.WriteLine("Первоначальный массив: {0}", string.Join(" ", arrayExample));

            Sort(arrayExample);

            Console.WriteLine("Отсортированный массив: {0}", string.Join(" ", arrayExample));

            Console.ReadKey();
        }
    }
}