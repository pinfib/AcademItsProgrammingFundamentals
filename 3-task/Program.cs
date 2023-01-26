using System.IO;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathInput = @"..\..\INPUT.txt";
            string pathOutput = @"..\..\OUTPUT.html";
            
            using (FileStream fStreamInput = new FileStream(pathInput, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fStreamOutput = new FileStream(pathOutput, FileMode.Create, FileAccess.Write))
                {
                    SimpleCSVReader.Reader(fStreamInput, fStreamOutput);
                }
            }
            
        }
    }
}
