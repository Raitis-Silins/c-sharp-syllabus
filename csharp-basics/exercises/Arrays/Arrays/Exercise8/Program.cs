using System;
using System.Text;

namespace Exercise8
{
    class Program
    {
        static void Main()
        {
            Game();
        }

        public static bool WordContains(string word, char guess)
        {
            return word.ToLower().IndexOf(guess) > -1;
        }

        public static void PlayAgain()
        {
            Console.WriteLine("Play the game again? PRESS y OR n");
            var userInput = Console.ReadKey();
            if (userInput.KeyChar == 'y')
            {
                Main();
            }

            Console.WriteLine("Thank you for playing!");
        }

        public static void Game()
        {
            string[] words = {"python", "Ruby", "Csharp", "JavaScript"};

            var random = new Random();
            var word = words[random.Next(0, words.Length)];

            var guessable = new string('*', word.Length);
            var misses = String.Empty;

            while (guessable.IndexOf('*') != -1 || misses.Length < 3)
            {
                Console.Clear();
                Console.WriteLine("Welcome to HangMan game, guess the hidden word !");

                Console.WriteLine("Hint: Its a programming language name.");
                Console.WriteLine($"Word contains: {guessable.Length} letters");
                Console.WriteLine();
                Console.WriteLine($"Your Misses: {misses}");
                Console.WriteLine();
                Console.WriteLine($"Word: {guessable}");
                var userInput = Console.ReadKey();
                var guess = userInput.KeyChar;
                Console.WriteLine();

                if (WordContains(word, guess))
                {
                    for (var i = 0; i < word.Length; i++)
                    {
                        if (word.ToLower()[i] == guess)
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = word[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                }

                if (guessable.Contains('*') == false)
                {
                    Console.Clear();
                    Console.WriteLine($"You won. The word was {guessable}");
                    PlayAgain();
                    break;
                }
                
                if (misses.Length == 3)
                {
                    Console.Clear();
                    Console.WriteLine("You lose!");
                    PlayAgain();
                    break;
                }
            }
        }
    }
}