using System;

namespace Exercise7
{
    class Program
    {
        static void Main()
        {
            DogTest test = new DogTest();
            Console.WriteLine(test.dog8.FathersName());
            Console.WriteLine(test.dog3.FathersName());

            Console.WriteLine(test.dog2.HasSameMotherAs(test.dog8));
        }
    }
}
