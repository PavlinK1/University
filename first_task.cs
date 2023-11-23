/* 
Exercise:
If we list all the natural numbers below 10 that are multiples of
3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
*/

using System;

public class Program
{
    public static void Main()
    {
        int limit = 1000;
        int sum = 0;
        int i = 0;

        while (i < limit)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                sum += i;
            }
            else if(i % 3 == 0)
            {
                sum += i;
            }
            else if(i % 5 == 0)
            {
                sum += i;
            }
            
            ++i;
        }

        Console.WriteLine("The sum is: {0:N0}", sum);
    }
}
