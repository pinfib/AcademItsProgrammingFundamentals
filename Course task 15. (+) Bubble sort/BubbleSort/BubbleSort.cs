using System;

namespace Academits.Dorosh
{
    class BubbleSort
    {
        public static void Sort(int[] array)
        {
            for (int i = array.Length; i > 1; i--)
            {
                bool wasExchange = false;

                for (int j = 1; j < i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;

                        wasExchange = true;
                    }
                }

                if (!wasExchange)
                {
                    return;
                }
            }
        }

        static void Main()
        {
            //int[] arrayExample = { 91, 17, 8, 7, 41, 58, 10, 6, 6, 1, 1 };
            int[] arrayExample = { 1, 1, 1, 1, 0 };

            Console.WriteLine("Первоначальный массив: {0}", string.Join(" ", arrayExample));

            Sort(arrayExample);

            Console.WriteLine("Отсортированный массив: {0}", string.Join(" ", arrayExample));

            Console.ReadKey();
        }
    }
}