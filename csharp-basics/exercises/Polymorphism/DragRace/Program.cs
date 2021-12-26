using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Tesla());
            cars.Add(new Lada());
            cars.Add(new Volvo());

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 1)
                    {
                        car.StartEngine();
                        continue;
                    }

                    if (i == 3)
                    {
                        if (car is IBoostable boostable)
                        {
                            boostable.UseNitrousOxideEngine();
                            continue;
                        }
                    }

                    car.SpeedUp();
                }
            }

            var fastest = cars.Max(t => int.Parse(t.ShowCurrentSpeed()));

            foreach (var car in cars)
            {
                if (int.Parse(car.ShowCurrentSpeed()) == fastest)
                {
                    Console.WriteLine($"Fastest car is : {car.GetType().Name}");
                }
            }
        }
    }
}