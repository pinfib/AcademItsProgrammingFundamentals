using System;

namespace CSharpCourseJan20
{
    internal class ExpressionsCalculation
    {
        private static void Main()
        {
            double x = 3 - (56 - 12) / 44 * (4 / 2);
            Console.WriteLine("Вычислим х: 3 - ((56 - 12) / 44) * (4 / 2) = {0}", x);

            double y = 2 * x / (33 - x);
            Console.WriteLine("Вычислим y: (2 * {0}) / (33 - {0}) = {1}", x, y);

            double z = -x / (2 * y);
            Console.WriteLine("Вычислим z: -{0} / (2 * {1}) = {2}", x, y, z);

            Console.ReadKey();
        }
    }
}