using System;

namespace Academits.Dorosh
{
    class BinarySearch
    {
        public static int GetElementIndexRecursive(int[] array, int left, int right, int searchElement)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = (left + right) / 2;

            if (searchElement == array[middle])
            {
                return middle;
            }

            if (searchElement < array[middle])
            {
                return GetElementIndexRecursive(array, left, middle - 1, searchElement);
            }

            return GetElementIndexRecursive(array, middle + 1, right, searchElement);
        }

        public static int GetElementIndexCycle(int[] array, int searchElement)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (searchElement == array[middle])
                {
                    return middle;
                }

                if (searchElement < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

        public static void PrintIndex(int index)
        {
            if (index == -1)
            {
                Console.WriteLine("Элемента нет в массиве.");
            }
            else
            {
                Console.WriteLine("Индекс элемента в массиве: {0}", index);
            }
        }

        static void Main()
        {
            int[] arrayExample = { 2, 4, 6, 8, 10, 12 };

            Console.Write("Массив: ");

            foreach (int e in arrayExample)
            {
                Console.Write(e + " ");
            }

            Console.WriteLine();

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат бинарного поиска с рекурсией: ");
            PrintIndex(GetElementIndexRecursive(arrayExample, 0, arrayExample.Length - 1, number));

            Console.WriteLine();

            Console.WriteLine("Результат бинарного поиска без рекурсии: ");
            PrintIndex(GetElementIndexCycle(arrayExample, number));

            Console.ReadKey();
        }
    }
}