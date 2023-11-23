/*
Exercise:
2520 is the smallest number that can be divided by each
of the numbers from 1 to 10 without any remainder. What
is the smallest positive number that is evenly divisible
by all of the numbers from 1 to 20? (We can start by 2520)
*/

using System;

public class Program
{
    public static void Main()
    {
        // Започвам от най-малкото делимо на всички от 1..10 (2520)
        int number = 2520;
        int smallestNumber = 0;
        bool checker = true;

        while (smallestNumber == 0)
        {
            for (int i = 1; i < 21; i++)
            {
                if(number % i != 0) 
                {
                    checker = false;
                    break;
                }
            }
            if (!checker)
            {
                number += 20;
                checker = true;
            }
            else if (checker)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine("The smallest number is: {0:N0}", smallestNumber);
    }

}