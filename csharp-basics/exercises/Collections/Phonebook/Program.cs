using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new PhoneBook.PhoneDirectory();

            test.PutNumber("Googe", "29668276");
            test.PutNumber("Oskars", "2991001");
            test.PutNumber("Rudofans Gors", "9095665");

            Console.WriteLine(test.GetNumber("Googe"));
        }
    }
}
