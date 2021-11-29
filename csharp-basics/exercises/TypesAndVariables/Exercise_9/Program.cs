using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance in meters:");
            float meters = float.Parse(Console.ReadLine());
            Console.Write("Input hours:");
            float hours = float.Parse(Console.ReadLine());
            Console.Write("Input minutes:");
            float minutes = float.Parse(Console.ReadLine());
            Console.Write("Input seconds:");
            float seconds = float.Parse(Console.ReadLine());
            Console.WriteLine("Output :");

            var secInTime = (hours * 3600) + (minutes * 60) + seconds;
            var metersPerSec = Math.Round(meters / secInTime, 2);
            var kilometersPerH = Math.Round((meters / 1000) / (secInTime / 3600), 2);
            var milesPerH = Math.Round(kilometersPerH / 1.609f, 2);

            Console.WriteLine($"Your speed in meters/second is {metersPerSec}");
            Console.WriteLine($"speed in km/h is {kilometersPerH}");
            Console.WriteLine($"speed in miles/h is {milesPerH}");
        }
    }
}
