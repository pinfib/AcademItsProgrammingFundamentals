using System;

namespace SymbolsCount
{
    class SymbolsCount
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string userString = Console.ReadLine();

            int lettersCount = 0;
            int digitsCount = 0;
            int whiteSpacesCount = 0;
            int otherSymbolsCount = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                char symbol = userString[i];

                if (char.IsLetter(symbol))
                {
                    lettersCount++;
                }
                else if (char.IsDigit(symbol))
                {
                    digitsCount++;
                }
                else if (char.IsWhiteSpace(symbol))
                {
                    whiteSpacesCount++;
                }
                else
                {
                    otherSymbolsCount++;
                }
            }

            Console.WriteLine("Количество букв: {0}", lettersCount);
            Console.WriteLine("Количество цифр: {0}", digitsCount);
            Console.WriteLine("Количество пробелов: {0}", whiteSpacesCount);
            Console.WriteLine("Количество прочих символов: {0}", otherSymbolsCount);

            Console.ReadKey();
        }
    }
}