﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class ArmstrongNumbers
{
    static void Main()
    {
        Console.WriteLine("Armstrong Numbers between 1 and 1000:");

        for (int number = 1; number <= 1000; number++)
        {
            int numDigits = 0;
            int temp = number;

            while (temp > 0)
            {
                temp /= 10;
                numDigits++;
            }

            temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, numDigits);
                temp /= 10;
            }

            if (number == sum)
            {
                Console.WriteLine(number);
            }
        }
    }
}
