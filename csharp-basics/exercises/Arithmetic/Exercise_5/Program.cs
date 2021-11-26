using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int numUserEntered = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            var randomNum = rnd.Next(1, 100);

            if (numUserEntered == randomNum)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            } 
            else if (numUserEntered > randomNum)
            {
                Console.WriteLine("Sorry, you are too high.  I was thinking of {0}.", randomNum);
            } 
            else
            {
                Console.WriteLine("Sorry, you are too low.  I was thinking of {0}.", randomNum);
            }
        }
    }
}
