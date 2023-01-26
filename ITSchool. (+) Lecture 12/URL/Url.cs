using System;

namespace Academits.Dorosh
{
    class Url
    {
        public static string GetServerName(string url)
        {
            int startIndex = url.IndexOf("://") + 3;

            int endIndex = url.IndexOf("/", startIndex);

            if (endIndex < 0)
            {
                endIndex = url.Length;
            }

            return url.Substring(startIndex, endIndex - startIndex);
        }

        static void Main()
        {
            string[] arrayExample = {
                "http://someservername/abcd/dfdf.htm?dfdf=dfdf",
                "http://someservername",
                "https://servername/site/subsite",
                "https://TestServer",
                "https://a"
                 };

            foreach (string e in arrayExample)
            {
                Console.WriteLine("Полный адрес: {0}, имя сервера: {1}", e, GetServerName(e));

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}