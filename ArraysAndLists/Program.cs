using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var Evens = new List<int>();
            var Odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Evens.Add(numbers[i]);

            //    }
            //    else
            //    {
            //        Odds.Add(num);
            //    }
            //}

            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    Evens.Add(num);
                }
                else
                {
                    Odds.Add(num);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var item in Evens)
            {
                Console.WriteLine($" {item} is an even number");
            }

            foreach(var item in Odds)
            {
                Console.WriteLine($" {item} is an odd number");
            }

        }
    }
}
