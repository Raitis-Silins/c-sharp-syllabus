
using System;

namespace Exercise_6
{
    public class CozaLozaWoza
    {
        public string CheckByIndex(int number)
        {
            var result = "";

            if (number % 5 == 0 && number % 7 == 0)
            {
                result += "LozaWoza ";
            }
            else if (number % 3 == 0 && number % 7 == 0)
            {
                result += "CozaWoza ";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                result += "CozaLoza ";
            }
            else if (number % 7 == 0)
            {
                result += "Woza ";
            }
            else if (number % 5 == 0)
            {
                result += "Loza ";
            }
            else if (number % 3 == 0)
            {
                result += "Coza ";
            }

            if (number % 5 != 0 && number % 7 != 0 && number % 3 != 0)
            {
                result += number + " ";
            }

            return result;
        }
        

        public string CozaLozaMain()
        {
            for (int i = 1; i <= 110; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write("LozaWoza ");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (i % 11 == 0)
                {
                    Console.WriteLine("\n");
                }
            }

            return null;
        }
    }
}
