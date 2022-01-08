using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new RandomArray();
            var makeArray = myArray.CreateArray(10);
            var cloneArray = myArray.ArrayClone(makeArray);

            Console.WriteLine(new RandomArray().DisplayArray(makeArray));
            Console.WriteLine(new RandomArray().DisplayArray(cloneArray));
        }
    }
}
