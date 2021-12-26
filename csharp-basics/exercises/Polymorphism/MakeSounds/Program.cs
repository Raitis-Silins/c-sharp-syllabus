using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var element = new List<ISound>();
            element.Add(new Firework());
            element.Add(new Parrot());
            element.Add(new Radio());

            foreach (var item in element)
            {
                item.PlaySound();
            }
        }
    }
}