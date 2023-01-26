using System;

namespace Academits.Dorosh
{
    class Deposit
    {
        public static double GetValue(string printMessage, string errorMessage)
        {
            while (true)
            {
                Console.Write(printMessage);
                double value = Convert.ToDouble(Console.ReadLine());

                if (value > 0)
                {
                    return value;
                }

                Console.WriteLine("Ошибка! " + errorMessage + " Повторите ввод.");
            }
        }

        static void Main()
        {
            double startDeposit = GetValue("Введите сумму вклада: ", "Вклад должен быть больше нуля.");
            int period = Convert.ToInt32(GetValue("Введите желаемый срок вклада: ", "Срок вклада должен быть больше нуля."));

            int monthsInYear = 12;
            double ratePerYear = 0.12;

            double ratePerMonth = ratePerYear / monthsInYear;

            double currentDeposit = startDeposit;

            for (int i = 0; i < period; i++)
            {
                currentDeposit += currentDeposit * ratePerMonth;
            }

            double profit = currentDeposit - startDeposit;

            Console.WriteLine("Сумма вклада под {0:#0.##%} годовых на конец периода составляет - {1:0.##}, прибыль - {2:0.##}", ratePerYear, currentDeposit, profit);

            Console.ReadKey();
        }
    }
}