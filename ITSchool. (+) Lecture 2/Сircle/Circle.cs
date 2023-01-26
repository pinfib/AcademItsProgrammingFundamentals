using System;

namespace CSharpCourseJan20
{
    class Circle
    {        
        static void Main()
        {
            double circleRadius = 5; 

            double circleArea = Math.PI * Math.Pow(circleRadius, 2);
            Console.WriteLine("Площадь круга, радиусом {0}, равна - {1:0.##}", circleRadius, circleArea);
            Console.WriteLine();

            double circleCircumference = 2 * Math.PI * circleRadius;
            Console.WriteLine("Длина окружности, радиусом {0}, равна - {1:0.##}", circleRadius, circleCircumference);
            Console.WriteLine();

            circleRadius = Math.Sqrt(circleArea / Math.PI);
            Console.WriteLine("Радиус круга площадью {0:0.##} (вычисленной ранее), равен - {1:0.##}", circleArea, circleRadius);
            Console.WriteLine();

            double sectorAngle = 45;

            double sectorArea = Math.PI * Math.Pow(circleRadius, 2) * (sectorAngle / 360);
            Console.WriteLine("Площадь сектора круга радиусом {0}, углом сектора {1}, равен - {2:0.##}", circleRadius, sectorAngle, sectorArea);

            Console.ReadLine();
        }
    }
}