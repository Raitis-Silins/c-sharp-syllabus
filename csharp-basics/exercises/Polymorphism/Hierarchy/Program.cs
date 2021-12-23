using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>()
            {
                new Cat("Ekleers", "Kaķis", 8.2, 0, "Ielas", "Parastais"),
                new Tiger("Ade ", "Tīģeris", 100.5, 0, "Africa")
            };

            var food = new List<Food>()
            {
                new Vegetable(12),
                new Meat(20)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.DisplayAnimal());
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine($"{food[0]}");
                Console.WriteLine(animal.Eat(food[0]));
            }

            Console.WriteLine("End");
            Console.WriteLine($"{animals[0]}, {animals[1]}");
        }
    }
}