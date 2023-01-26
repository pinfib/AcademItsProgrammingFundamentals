using System;

namespace Academits.Dorosh
{
    class OrderCost
    {
        public static int GetProductsCount()
        {
            while (true)
            {
                int productsCount = Convert.ToInt32(Console.ReadLine());

                if (productsCount >= 0)
                {
                    return productsCount;
                }

                Console.Write("Ошибка! Количество не может быть отрицательным. Повторите ввод: ");
            }
        }

        public static bool IsLargerOrEqual(double a, double b)
        {
            double epsilon = 1.0e-10;

            return a - b >= -epsilon;
        }

        public static double GetOrderCost(int products1Count, double product1Cost, int products2Count, double product2Cost)
        {
            double orderCost = products1Count * product1Cost + products2Count * product2Cost;

            double maxDiscount = 0.1;
            double minDiscount = 0.05;

            double costLimit = 1000;
            int countLimit = 10;

            if (products1Count + products2Count >= countLimit && IsLargerOrEqual(orderCost, costLimit))
            {
                return orderCost - orderCost * maxDiscount;
            }

            if (products1Count + products2Count >= countLimit || IsLargerOrEqual(orderCost, costLimit))
            {
                return orderCost - orderCost * minDiscount;
            }

            return orderCost;
        }

        static void Main()
        {
            Console.Write("Введите количество первого товара: ");
            int products1Count = GetProductsCount();

            Console.Write("Введите количество второго товара: ");
            int products2Count = GetProductsCount();

            double product1Cost = 149.99;
            double product2Cost = 300;

            Console.WriteLine("Стоимость заказа с учетом скидок: {0:0.##}", GetOrderCost(products1Count, product1Cost, products2Count, product2Cost));

            Console.ReadKey();
        }
    }
}