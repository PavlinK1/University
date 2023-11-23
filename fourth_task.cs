/*
Palindrome - Това означава, 9009 и РОР на обратно е същото!
https://www.tutorialspoint.com/Chash-program-to-check-if-a-string-is-palindrome-or-not (Източник за reverse string метод, 
в случая аз работя с int, а не със string, затова сменям типа му на string заради reverse метода.)

Exercise:
A palindromic number reads the same both ways. 
The largest palindrome made from the product of
two 2-digit numbers is 9009 = 91 × 99. Find the
largest palindrome made from the product of two
3-digit numbers.
*/

using System;

public class Palindrome
{
    public static void Main()
    {
        int largestNumber = 0;

        for (int i = 100; i < 1000; i++) 
        {
            for (int k = 100; k < 1000; k++) 
            {
                if (IsPalindrome(i * k) && largestNumber < i * k)
                {
                    largestNumber = i * k;
                }
            }
        }
        Console.WriteLine("The largest palindrome is: {0:N0}", largestNumber);
    }

    public static bool IsPalindrome(int number) 
    {
        string original = number.ToString();
        char[] charArray = original.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        return original == reversed;
    }

}