using System;

namespace Switch
{
    class Switch
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите код команды: ");
            int commandCode = Convert.ToInt32(Console.ReadLine());

            double result;

            switch (commandCode)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine("Выбрано \"Сложение\": {0} + {1} = {2:#0.####} ", a, b, result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine("Выбрано \"Вычитание\": {0} - {1} = {2:#0.####} ", a, b, result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine("Выбрано \"Умножение\": {0} * {1} = {2:#0.####} ", a, b, result);
                    break;
                case 4:
                    result = a / b;
                    Console.WriteLine("Выбрано \"Деление\": {0} / {1} = {2:#0.####} ", a, b, result);
                    break;
                default:
                    Console.WriteLine("Неизвестная команда.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
