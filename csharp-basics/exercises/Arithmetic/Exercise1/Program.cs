﻿using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIntegers(6, 21));
        }

        public static bool CheckIntegers(int num1, int num2)
        {
            return num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15;
        }
    }
}
