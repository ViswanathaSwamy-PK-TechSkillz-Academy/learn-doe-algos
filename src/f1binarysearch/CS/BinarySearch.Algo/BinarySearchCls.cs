// File: BinarySearchCls.cs

namespace BinarySearch.Algo;

public static class BinarySearchCls
{
    // Performs a binary search on a sorted array of integers. Returns the index of the target if found, or -1 if the target is not in the array.
    public static int Search(int[] numbers, int target)
    {
        int low = 0;
        int high = numbers.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (numbers[mid] == target)
            {
                return mid;
            }

            if (target < numbers[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }
}
