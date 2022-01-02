
using System;

namespace Exercise_6
{
    public class CozaLozaWoza
    {
        public string CheckByIndex(int number)
        {
            if (number % 5 == 0 && number % 7 == 0)
            {
                return "LozaWoza ";
            }
            else if (number % 3 == 0 && number % 7 == 0)
            {
                return "CozaWoza ";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                return "CozaLoza ";
            }
            else if (number % 7 == 0)
            {
                return "Woza ";
            }
            else if (number % 5 == 0)
            {
                return "Loza ";
            }
            else if (number % 3 == 0)
            {
                return "Coza ";
            }
            else
            {
                return number + " ";
            }
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
