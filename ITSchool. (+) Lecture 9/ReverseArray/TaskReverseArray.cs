using System;

namespace Academits.Dorosh
{
    class TaskReverseArray
    {
        public static void ReverseArray(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }

        static void Main()
        {
            int[] arrayExample = { 1, 2, 3, 4, 5, 6, 7 };

            Console.Write("Первоначальный массив: \t\t");

            foreach (int e in arrayExample)
            {
                Console.Write(e + " ");
            }

            ReverseArray(arrayExample);

            Console.WriteLine();

            Console.Write("Обратный порядок элементов: \t");

            foreach (int e in arrayExample)
            {
                Console.Write(e + " ");
            }

            Console.ReadKey();
        }
    }
}