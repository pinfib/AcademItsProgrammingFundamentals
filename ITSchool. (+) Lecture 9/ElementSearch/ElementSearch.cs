using System;

namespace Academits.Dorosh
{
    class ElementSearch
    {
        public static int GetElementIndex(int[] array, int searchElement)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchElement)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main()
        {
            int[] arrayExample = { 1, 2, 5, 10, 100, 7 };

            foreach (int e in arrayExample)
            {
                Console.Write(e + " ");
            }

            Console.WriteLine();

            Console.Write("Введите значение, которое нужно найти: ");
            int searchElement = Convert.ToInt32(Console.ReadLine());

            int index = GetElementIndex(arrayExample, searchElement);

            if (index == -1)
            {
                Console.WriteLine("Элемент отсутствует в массиве");
            }
            else
            {
                Console.WriteLine("Индекс элемента в массиве: {0}", index);
            }

            Console.ReadKey();
        }
    }
}