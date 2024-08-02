// File: FindDifference.cs

namespace BWMFindDifference.Algo;

public static class DifferenceFinder
{
    public static int ExtraCharacterIndex(string str1, string str2)
    {
        int result = 0;

        for (int i = 0; i < str1.Length; i++)
        {
            result ^= str1[i];
        }

        for (int i = 0; i < str2.Length; i++)
        {
            result ^= str2[i];
        }

        return str1.Length > str2.Length ? str1.IndexOf((char)result) : str2.IndexOf((char)result);
    }
}
