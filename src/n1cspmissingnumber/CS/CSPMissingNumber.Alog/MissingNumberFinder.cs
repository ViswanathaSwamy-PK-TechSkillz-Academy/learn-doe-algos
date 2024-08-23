// File: MissingNumberFinder.cs

namespace CSPMissingNumber.Alog;

public static class MissingNumberFinder
{
    public static int FindMissingNumber(int[] numbers)
    {
        int numbersLength = numbers.Length;
        int index = 0;

        while (index < numbersLength)
        {
            int value = numbers[index];

            if (value < numbersLength && value != numbers[value])
            {
                (numbers[index], numbers[value]) = (numbers[value], numbers[index]);
            }
            else
            {
                index++;
            }
        }

        for (int i = 0; i < numbersLength; i++)
        {
            if (i != numbers[i])
            {
                return i;
            }
        }

        return numbersLength;
    }
}
