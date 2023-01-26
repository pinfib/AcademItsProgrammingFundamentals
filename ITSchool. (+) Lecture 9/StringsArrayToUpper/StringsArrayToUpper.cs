using System;

namespace Academits.Dorosh
{
    class StringsArrayToUpper
    {
        public static void ConvertArrayToUpper(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToUpper();
            }
        }

        static void Main()
        {
            string[] arrayExample = { "Строка 1", "строка 2", "строка 3" };

            Console.Write("Первоначальный массив: ");

            foreach (string e in arrayExample)
            {
                Console.Write(e + " ");
            }

            ConvertArrayToUpper(arrayExample);

            Console.WriteLine();

            Console.Write("В верхнем регистре: ");

            foreach (string e in arrayExample)
            {
                Console.Write(e + " ");
            }

            Console.ReadKey();
        }
    }
}