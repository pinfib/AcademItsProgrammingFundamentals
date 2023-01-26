using System;

namespace Academits.Dorosh
{
    class Palindrome
    {
        public static bool IsPalindrome(string stringToCheck)
        {
            if (string.IsNullOrEmpty(stringToCheck) || stringToCheck.Length == 1)
            {
                return true;
            }

            stringToCheck = stringToCheck.ToLower();

            for (int i = 0, j = stringToCheck.Length - 1; i <= j; i++, j--)
            {
                while (!char.IsLetter(stringToCheck[i]))
                {
                    i++;

                    if (i >= stringToCheck.Length)
                    {
                        return true;
                    }
                }

                while (!char.IsLetter(stringToCheck[j]))
                {
                    j--;
                }

                if (stringToCheck[i] != stringToCheck[j])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            string[] stringExamples =
            {
                "Аргентина манит негра" ,
                "А роза упала на лапу Азора" ,
                "Was it a car, or a cat I saw?",
                "оно",
                "Не палиндром",
                "a",
                "аб",
                "             ",
                ""
            };

            foreach (string e in stringExamples)
            {
                if (IsPalindrome(e))
                {
                    Console.WriteLine("Палиндром: \t" + e);
                }
                else
                {
                    Console.WriteLine("Не палиндром: \t" + e);
                }
            }

            Console.ReadKey();
        }
    }
}