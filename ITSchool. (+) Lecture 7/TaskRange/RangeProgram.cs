using System;

namespace Academits.Dorosh
{
    class RangeProgram
    {
        static void Main()
        {
            Range range = RangeCreation.GetRange();

            Console.WriteLine("Вы ввели диапазон от {0} до {1}.", range.From, range.To);
            Console.WriteLine("Его длина: {0}", range.GetLength());

            Console.Write("Введите значение, чтобы проверить входит ли оно в заданный диапазон: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (range.IsInside(number))
            {
                Console.WriteLine("Значение {0} входит в заданный диапазон.", number);
            }
            else
            {
                Console.WriteLine("Значение {0} не входит в заданный диапазон.", number);
            }

            Console.ReadKey();
        }
    }
}