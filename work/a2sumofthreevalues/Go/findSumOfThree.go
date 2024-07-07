package main

import (
	"sort"
)

// FindSumOfThree checks if there are three numbers in the slice that add up to the target value.
func FindSumOfThree(nums []int, target int) bool {
	sort.Ints(nums) // Sort the array in ascending order

	for i := 0; i < len(nums)-2; i++ {
		left, right := i+1, len(nums)-1

		for left < right {
			sum := nums[i] + nums[left] + nums[right]

			if sum == target {
				return true // Triplet found!
			} else if sum < target {
				left++ // Move left pointer to increase the sum
			} else {
				right-- // Move right pointer to decrease the sum
			}
		}
	}

	return false // Triplet not found
}
