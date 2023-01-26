using System;

namespace CSharpCourseJan20
{
    class OutputStrings
    {
        static void Main()
        {
            /* Задание: Вывести при помощи одного метода Console.WriteLine несколько строк */

            Console.WriteLine(  "Hello, world!" + Environment.NewLine +
                                "\"30\" августа 2014г." + Environment.NewLine + 
                                @"C:\Windows\System32\Drivers\etc\hosts" + Environment.NewLine + 
                                "2 + 2 * 2 = " + (2 + 2 * 2));

            Console.ReadKey(); Console.ReadKey();
        }
    }
}
