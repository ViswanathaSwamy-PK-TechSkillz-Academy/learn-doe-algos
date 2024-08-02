// File: FindDifference.cs

namespace FindDifference;

public static class DifferenceFinder
{
    public static int ExtraCharacterIndex(string str1, string str2)
    {
        int result = 0;
        int str1Length = str1.Length;
        int str2Length = str2.Length;

        for (int i = 0; i < str1Length; i++)
        {
            result ^= str1[i];
        }

        for (int i = 0; i < str2Length; i++)
        {
            result ^= str2[i];
        }

        if (str1Length > str2Length)
        {
            return str1.IndexOf((char)result);
        }
        else
        {
            return str2.IndexOf((char)result);
        }
    }
}