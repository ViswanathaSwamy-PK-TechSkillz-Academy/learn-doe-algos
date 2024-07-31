namespace BinarySearch.Algo;

public static class BinarySearch
{
    // Performs a binary search on a sorted array of integers.
    // Returns the index of the target if found, or -1 if the target is not in the array.
    public static int Search(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (target < nums[mid])
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
