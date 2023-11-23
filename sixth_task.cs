using System;

public class Program
{
    public static void Main()
    {
        double SquareRoot;
        int value;
        int power = 2;
        int limit = 1000;
        double result = 0;

        for (value = 1; value <= limit; value++) 
        {
            double pow = Math.Pow(value, power);
            result = result + pow;
            // Console.WriteLine($"{value}^{power} = {pow:N0}");
        }

        SquareRoot = findSquareOfSum(limit, power);

        // Console.WriteLine($"The sum of the square of all consecutive numbers from 1 to {limit:N0} (inclusive) is {result:N0}");
        // Console.WriteLine($"The square of the sum of all consecutive numbers from 1 to {limit:N0} (inclusive) is {SquareRoot:N0}");
        Console.WriteLine($"The difference between the square of the sum and the sum of the square is {SquareRoot - result:N0}");
    }

    public static double findSquareOfSum(int lim, int po)
    {
        int sum = 0;
        int value;
        for (value = 1; value <= lim; value++) 
        {
            sum += value;
        }
        double test = Math.Pow(sum, po);
        return test;
    }
}
