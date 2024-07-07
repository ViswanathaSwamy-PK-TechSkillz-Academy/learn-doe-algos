namespace FSP.Algo;

public class HappyNumberHelper
{
    // Helper function that calculates the sum of squared digits
    private static int SumOfSquaredDigits(int number)
    {
        int totalSum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            number /= 10;
            totalSum += digit * digit;
        }
        return totalSum;
    }

    // Function to check if a number is a happy number
    public static bool IsHappyNumber(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = SumOfSquaredDigits(n);
        }

        return n == 1;
    }
}
