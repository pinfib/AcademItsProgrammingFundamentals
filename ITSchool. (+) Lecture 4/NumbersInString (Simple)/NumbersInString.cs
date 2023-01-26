using System;

namespace NumbersInStringSimple
{
    class NumbersInString
    {
        static void Main()
        {
            int i = 1;

            while (i <= 100)
            {
                Console.Write("{0, 4}", i);

                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }

                i++;
            }

            Console.ReadKey();
        }
    }
}
