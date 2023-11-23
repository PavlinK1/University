/*
Prime number (Просто число) is a number that can only be divided by itself and 1 without remainders
Prime factor - Това означава, че като почнем да делим от числото 2, трябва
да получаваме число без остатък, ако ли не делим на следващите (3,4...n)

Exercise:
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?

*/

using System;

public class primeFactor
{
    public static void Main()
    {
        long Number = 600851475143;
        long lockNumber = Number;
        int biggestPrimeFactor = 0;
        int factor = 2;

        while (true)
        {
            if (Number % factor == 0 && lockNumber != factor)
            {
                biggestPrimeFactor = factor;
                Number /= factor;
                biggestPrimeFactor = checkerOfBiggestPrimeFactor(biggestPrimeFactor, factor);
                Console.WriteLine("Check factor {0}", factor);
            }
            else if (Number == 1)
            {
                break;
            }
            
            ++factor;
        }

        Console.WriteLine("Biggest Prime Factor -> {0:N0}", biggestPrimeFactor);
    }

    public static int checkerOfBiggestPrimeFactor(int biggestFactor, int lastFactor)
    {
        if (biggestFactor < lastFactor)
        {
            biggestFactor = lastFactor;
        }
        return biggestFactor;
    }
}

