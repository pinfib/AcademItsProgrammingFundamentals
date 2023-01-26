using System;

namespace Academits.Dorosh
{
    class TemperaturesConversion
    {
        public static double GetKelvinDegrees(double celsiusDegrees)
        {
            return celsiusDegrees + 273.15;
        }

        public static double GetFahrenheitDegrees(double celsiusDegrees)
        {
            return celsiusDegrees * 9 / 5 + 32;
        }

        static void Main()
        {
            Console.Write("Введите температуру в градусах Цельсия: ");
            double celsiusDegrees = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("По шкале Кельвина - {0:0.####}°", GetKelvinDegrees(celsiusDegrees));
            Console.WriteLine("По шкале Фаренгейта - {0:0.####}°.", GetFahrenheitDegrees(celsiusDegrees));

            Console.ReadKey();
        }
    }
}