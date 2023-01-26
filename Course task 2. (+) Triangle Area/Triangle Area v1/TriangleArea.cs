using System;

namespace CSharpCourseJan20
{
    class TriangleArea
    {
        private static Point GetPoint(string userLine)
        {
            char[] charSeparators = { ' ' };
            string[] coordinates = userLine.Split(charSeparators);

            try
            {
                return new Point(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1]));
            }
            catch
            {
                Console.WriteLine("Ошибка ввода. Точке присвоены координаты (0, 0)");
                return new Point(0, 0);
            }
        }

        private static bool IsTriangle(Point pointA, Point pointB, Point pointC)
        {
            double equationRightPart = (pointA.X - pointC.X) * (pointB.Y - pointC.Y);
            double equationLeftPart = (pointB.X - pointC.X) * (pointA.Y - pointC.Y);

            double epsilon = 0.0001;

            return Math.Abs(equationRightPart - equationLeftPart) > epsilon;
        }

        private static double GetTriangleSideLength(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
        }

        private static void Main()
        {
            Console.WriteLine("Введите координаты вершин треугольника, X и Y, через пробел:");

            Console.Write("Введите точку А: ");
            Point pointA = GetPoint(Console.ReadLine());

            Console.Write("Введите точку B: ");
            Point pointB = GetPoint(Console.ReadLine());

            Console.Write("Введите точку C: ");
            Point pointC = GetPoint(Console.ReadLine());

            Console.WriteLine("Вы ввели: A({0}, {1}), B({2}, {3}), C({4}, {5})", pointA.X, pointA.Y, pointB.X, pointB.Y, pointC.X, pointC.Y);

            if (!IsTriangle(pointA, pointB, pointC))
            {
                Console.WriteLine("Это не треугольник");
            }
            else
            {
                double sideAB = GetTriangleSideLength(pointA, pointB);
                double sideBC = GetTriangleSideLength(pointB, pointC);
                double sideAC = GetTriangleSideLength(pointA, pointC);

                double semiPerimeter = (sideAB + sideBC + sideAC) / 2;
                double triangleArea = Math.Sqrt(semiPerimeter * ((semiPerimeter - sideAB) * (semiPerimeter - sideBC) * (semiPerimeter - sideAC)));

                Console.WriteLine("Длины сторон треугольника: AB = {0:0.##}; BC = {1:0.##}; AC = {2:0.##}. Площадь = {3:0.##}", sideAB, sideBC, sideAC, triangleArea);
            }

            Console.ReadKey();
        }
    }
}