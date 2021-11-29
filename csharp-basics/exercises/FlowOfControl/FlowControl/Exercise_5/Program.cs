using System;
using System.Threading.Channels;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneKeyPad();
        }

        static void PhoneKeyPad()
        {
            Console.WriteLine("Write a text to convert it to sequence of keypad digits.");
            var userInput = Console.ReadLine();
            var input = userInput.ToLower();

            var keyPadNum = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        keyPadNum = 2;
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        keyPadNum = 3;
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        keyPadNum = 4;
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        keyPadNum = 5;
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        keyPadNum = 6;
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        keyPadNum = 7;
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        keyPadNum = 8;
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        keyPadNum = 9;
                        break;
                }
                Console.Write(keyPadNum + " ");
            }
        }
    }
}
