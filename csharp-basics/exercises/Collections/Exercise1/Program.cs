using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> cars = new List<string>();
            cars.Add("Audi");
            cars.Add("BMW");
            cars.Add("Honda");
            cars.Add("Mercedes");
            cars.Add("VolksWagen");
            cars.Add("Mercedes");
            cars.Add("Tesla");

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            var hashSet = new HashSet<string>(array);

            foreach (var car in hashSet)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            IDictionary<string, string> carNames = new Dictionary<string, string>();
            carNames.Add("Audi", "Germany");
            carNames.Add("BMW", "Germany");
            carNames.Add("Honda", "Japan");
            carNames.Add("Mercedes", "Germany");
            carNames.Add("VolksWagen", "Germany");
            carNames.Add("Tesla", "USA");

            foreach (KeyValuePair<string, string> car in carNames)
            {
                Console.WriteLine("{0} -> {1}", car.Key, car.Value);
            }

        }
    }
}
