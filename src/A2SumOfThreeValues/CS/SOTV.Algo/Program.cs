static bool FindSumOfThree(int[] numbers, int target)
{
    // Sort the array in ascending order
    Array.Sort(numbers);

    for (int i = 0; i < numbers.Length - 2; i++)
    {
        int left = i + 1;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int sum = numbers[i] + numbers[left] + numbers[right];

            if (sum == target)
            {
                return true;    // Triplet found!
            }
            else if (sum < target)
            {
                left++;         // Move left pointer to increase the sum
            }
            else
            {
                right--;        // Move right pointer to decrease the sum
            }
        }
    }

    return false;
}

// Example usage
int[] numbers = [1, 4, 2, 7, 5, 3];
int target = 10;

Console.WriteLine("Sum of Three Numbers: " + FindSumOfThree(numbers, target)); // Output: True
