using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var casinoRoyale = new Movie("Casino Royale", "", "PG13");
            var glass = new Movie("Glass", "Buena Vista International", "PG13");
            var spiderMan = new Movie("Spider-Verse", "Columbia Pictures", "PG");

            var movies = new List<Movie>
            {
                spiderMan,
                casinoRoyale,
                glass
            };

            var filtered = GetPG(movies.ToArray());
            foreach (var movie in filtered)
            {
                Console.WriteLine($"{movie.Display()}");
            }
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            return movies.Where(m => m.Rating == "PG").ToArray();
        }
    }
}
