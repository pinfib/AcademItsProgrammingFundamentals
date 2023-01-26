using System;

namespace Academits.Dorosh
{
    class HeapSort
    {
        public static void Screen(int[] array, int length, int i)
        {
            int middle = array.Length / 2 - 1;
            int largest = i;

            while (true)
            {
                int left = 2 * i + 1;

                if (left < length && array[left] > array[largest])
                {
                    largest = left;
                }

                int right = 2 * i + 2;

                if (right < length && array[right] > array[largest])
                {
                    largest = right;
                }

                if (largest == i)
                {
                    break;
                }

                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                i = largest;

                if (i > middle)
                {
                    break;
                }
            }
        }

        public static void Sort(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Screen(array, array.Length, i);
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Screen(array, i, 0);
            }
        }

        static void Main()
        {
            int[] arrayExample = { 1, 0, 6, 1, 0, 1, 0, 6 };

            Console.WriteLine("Первоначальный массив: {0}", string.Join(" ", arrayExample));

            Sort(arrayExample);

            Console.WriteLine("Отсортированный массив: {0}", string.Join(" ", arrayExample));

            Console.ReadKey();
        }
    }
}