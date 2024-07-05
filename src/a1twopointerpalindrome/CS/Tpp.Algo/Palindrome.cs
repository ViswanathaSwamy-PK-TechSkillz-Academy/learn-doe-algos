// Palindrome.cs
using System;

namespace Tpp.Algo;

public static class PalindromeChecker
{
    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            WriteLine($"Current elements left index: '{s[left]}' and right index: '{s[right]}'");

            if (s[left] != s[right])
            {
                WriteLine("The elements aren't the same, hence we return false");
                return false;
            }

            left++; // Heading towards the right
            right--; // Heading towards the left
        }

        return true;
    }
}
