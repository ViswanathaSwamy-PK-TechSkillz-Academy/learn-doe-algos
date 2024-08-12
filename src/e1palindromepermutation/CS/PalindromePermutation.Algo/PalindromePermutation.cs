// PalindromePermutation.cs

namespace PalindromePermutation.Algo;

public static class PalinPermutation
{
    public static bool CanPermutePalindrome(string s)
    {
        Dictionary<char, int> charCount = [];

        foreach (char c in s)
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
        foreach (int count in charCount.Values)
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
