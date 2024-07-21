package main

// binarySearch performs a binary search on a sorted slice of integers.
// It returns the index of the target if found, or -1 if the target is not in the slice.
func binarySearch(nums []int, target int) int {
	low := 0
	high := len(nums) - 1

	for low <= high {
		mid := (low + (high - low)) / 2
		if nums[mid] == target {
			return mid
		}
		if target < nums[mid] {
			high = mid - 1
		} else {
			low = mid + 1
		}
	}

	return -1
}
