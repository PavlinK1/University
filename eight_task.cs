using System;

public class Program
{
    public static void Main()
    {
        int target = 1000;

        for (int a = 1; a < target; a++)
        {
            for (int b = 1; b < target; b++)
            {
                int c = target - a - b;

                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    Console.WriteLine($"Pythagorean triplet: a = {a}, b = {b}, c = {c}");
                    Console.WriteLine($"Product of abc = {a * b * c:N0}");
                    return;
                }
            }
        }
    }
}