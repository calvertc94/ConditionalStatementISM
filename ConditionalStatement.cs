﻿using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade would you like to receive in ISM4300?");
                int grade = int.Parse(Console.ReadLine());

                if (grade >= 98 && grade <= 100)
                {
                    Console.WriteLine("Your grade in ISM is an A+");
                }
                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("Your grade in ISM is an A");
                }
                else if (grade >= 90 && grade <= 91)
                {
                    Console.WriteLine("Your grade in ISM is an A-");
                }
                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("Your grade in ISM is an B+");
                }
                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("Your grade in ISM is an B");
                }
                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("Your grade in ISM is an B-");
                }
                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("Your grade in ISM is an C+");
                }
                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("Your grade in ISM is an C");
                }
                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("Your grade in ISM is an C-");
                }
                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("Your grade in ISM is an D+");
                }
                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("Your grade in ISM is an D");
                }
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("Your grade in ISM is an D-");
                }
                else if (grade <= 59)
                {
                    Console.WriteLine("Your grade is ISM an F");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a number between 0 and 100");
            }
        }
    }
}