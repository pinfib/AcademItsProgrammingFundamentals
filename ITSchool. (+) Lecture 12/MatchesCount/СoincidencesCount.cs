using System;
using System.IO;

namespace Academits.Dorosh
{
    class СoincidencesCount
    {
        public static int GetСoincidencesCount(string substring, string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                substring = substring.ToLower();

                int coincidencesCount = 0;
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    currentLine = currentLine.ToLower();

                    int startIndex = 0;

                    while (true)
                    {
                        startIndex = currentLine.IndexOf(substring, startIndex);

                        if (startIndex == -1)
                        {
                            break;
                        }

                        startIndex += substring.Length;

                        coincidencesCount++;
                    }
                }

                return coincidencesCount;
            }
        }

        static void Main()
        {
            string path = "..\\..\\input.txt";

            string substring = "System";

            Console.WriteLine("Число вхождений подстроки \"{0}\" - {1}", substring, GetСoincidencesCount(substring, path));

            Console.ReadKey();
        }
    }
}