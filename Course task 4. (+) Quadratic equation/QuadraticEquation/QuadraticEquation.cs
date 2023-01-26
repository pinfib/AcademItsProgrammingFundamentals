using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        public static bool IsEqual(double a, double b)
        {
            double epsilon = 1.0e-10;

            return Math.Abs(a - b) <= epsilon;
        }

        public static bool IsSmaller(double a, double b)
        {
            double epsilon = 1.0e-10;

            return a - b < -epsilon;
        }

        static void Main()
        {
            Console.WriteLine("Программа вычисляет корни квадратного уравнения ax^2 + bx + c = 0. Введите коэффициенты уравнения:");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (IsEqual(a, 0) && IsEqual(b, 0) && IsEqual(c, 0))
            {
                Console.WriteLine("Корень уравнения: x - любое число");
            }
            else if (IsEqual(a, 0) && IsEqual(b, 0))
            {
                Console.WriteLine("Корней нет");
            }
            else if (IsEqual(a, 0))
            {
                double x = -c / b;
                Console.WriteLine("Корень уравнения: x = {0:0.###}", x);
            }
            else
            {
                double discriminant = Math.Pow(b, 2) - 4 * a * c;

                if (IsSmaller(discriminant, 0))
                {
                    Console.WriteLine("Корней нет");
                }
                else if (IsEqual(discriminant, 0))
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Корень уравнения: x = {0:0.###}", x);
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("Корни уравнения: x1 = {0:0.###}, x2 = {1:0.###}", x1, x2);
                }
            }

            Console.ReadLine();
        }
    }
}