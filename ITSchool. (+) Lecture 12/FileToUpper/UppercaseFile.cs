using System.IO;

namespace Academits.Dorosh
{
    class UppercaseFile
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("..\\..\\input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("..\\..\\output.txt"))
                {
                    string currentLine;

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        currentLine = currentLine.ToUpper();

                        writer.WriteLine(currentLine);
                    }
                }
            }
        }
    }
}