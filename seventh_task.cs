/*
Prime number (Просто число) is a number that can only be divided by itself and 1 without remainders
Prime factor - Това означава, че като почнем да делим от числото 2, трябва
да получаваме число без остатък, ако ли не делим на следващите (3,4...n)

Exercise:
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13,
we can see that the 6th prime is 13. What is the 10 001st prime number?

*/

using System;

public class Program
{
   public static void Main()
   {
       int value = 0;
       int counter = 0;
       while (true)
       {
           bool checker = checkerForPrime(value);
           if (checker)
           {
               ++counter;
           }

           if (counter == 10001)
           {
               Console.WriteLine($"10,001st prime number is -> {value:N0}");
               break;
           }
           ++value;
       }
   }

   public static bool checkerForPrime(int x)
   {
        if (x < 2 || x % 2 == 0 && x != 2)
        {
            return false;
        }
        /*
        Ако x се дели на число, което е по-голямо от неговия квадратен корен, 
        то също така трябва да се дели и на число, което е по-малко от неговия
        квадратен корен. Затова, за да определим дали едно число е просто, можем да
        проверим само делителите до неговия квадратен корен.
        */
        double squareRoot = Math.Floor(Math.Sqrt(x));
        for (int divisor = 3; divisor <= squareRoot; divisor += 2)
        {
            if (x % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }
}