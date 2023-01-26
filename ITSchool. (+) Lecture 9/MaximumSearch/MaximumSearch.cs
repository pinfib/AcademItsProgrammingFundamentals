using System;

namespace Academits.Dorosh
{
    class MaximumSearch
    {
        public static double GetArrayMaximum(double[] array)
        {
            double max = array[0];

            foreach (double e in array)
            {
                max = Math.Max(e, max);
            }

            return max;
        }

        static void Main()
        {
            double[] arrayExample = { 0.1, 0.2, 0.3, 0.1, 0.81, 0.09, 0.80, 0.79 };

            Console.Write("Массив: ");

            foreach (double e in arrayExample)
            {
                Console.Write(e + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Максимальный элемент: {0}", GetArrayMaximum(arrayExample));

            Console.ReadKey();
        }
    }
}