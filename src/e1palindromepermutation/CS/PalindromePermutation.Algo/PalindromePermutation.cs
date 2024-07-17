// PalindromePermutation.cs
using System.Collections.Generic;

namespace PalindromePermutation.Algo;

public static class PalinPermutation
{
    public static bool CanPermutePalindrome(string s)
    {
        var charCount = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        int oddCount = 0;
        foreach (var count in charCount.Values)
        {
            if (count % 2 != 0)
            {
                oddCount++;
            }

            if (oddCount > 1)
            {
                return false;
            }
        }

        return true;
    }
}
