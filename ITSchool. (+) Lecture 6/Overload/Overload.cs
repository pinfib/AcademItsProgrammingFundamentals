using System;

namespace Academits.Dorosh
{
    class Overload
    {
        public static int GetTypeSize(byte value)
        {
            return 1;
        }

        public static int GetTypeSize(short value)
        {
            return 2;
        }

        public static int GetTypeSize(int value)
        {
            return 4;
        }

        public static int GetTypeSize(long value)
        {
            return 8;
        }

        public static int GetTypeSize(float value)
        {
            return 4;
        }

        public static int GetTypeSize(double value)
        {
            return 8;
        }

        static void Main()
        {
            byte a = 0;
            Console.WriteLine("Переменная типа byte занимает байт: \t{0}", GetTypeSize(a));

            short b = 0;
            Console.WriteLine("Переменная типа short занимает байт: \t{0}", GetTypeSize(b));

            int c = 0;
            Console.WriteLine("Переменная типа int занимает байт: \t{0}", GetTypeSize(c));

            long d = 0;
            Console.WriteLine("Переменная типа long занимает байт: \t{0}", GetTypeSize(d));

            float e = 0;
            Console.WriteLine("Переменная типа float занимает байт: \t{0}", GetTypeSize(e));

            double f = 0;
            Console.WriteLine("Переменная типа double занимает байт: \t{0}", GetTypeSize(f));

            Console.ReadKey();
        }
    }
}