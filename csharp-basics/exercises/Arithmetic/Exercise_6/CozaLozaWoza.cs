
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
    }
}
