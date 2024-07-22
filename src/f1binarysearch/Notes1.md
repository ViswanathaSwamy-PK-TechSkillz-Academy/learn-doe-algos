# Modified Binary Search

## 1. Binary Search on a Modified Array

Let's consider an example where the array is sorted and then rotated around some unknown pivot. The binary search can be adapted to handle this scenario by first identifying the pivot point and then performing the binary search in the appropriate subarray.

### Example: Rotated Sorted Array

In this example, the array might look like this: `[4, 5, 6, 7, 0, 1, 2]`. Here's the modified binary search:

```go
package main

import (
	"fmt"
)

// findPivot finds the index of the smallest element (pivot) in the rotated sorted array.
func findPivot(nums []int) int {
	low, high := 0, len(nums) - 1
	for low < high {
		mid := low + (high - low) / 2
		if nums[mid] > nums[high] {
			low = mid + 1
		} else {
			high = mid
		}
	}
	return low
}

// binarySearch performs a binary search on a sorted slice of integers.
func binarySearch(nums []int, target int) int {
	low, high := 0, len(nums) - 1
	for low <= high {
		mid := low + (high - low) / 2
		if nums[mid] == target {
			return mid
		}
		if nums[mid] < target {
			low = mid + 1
		} else {
			high = mid - 1
		}
	}
	return -1
}

// searchInRotatedArray searches for a target in a rotated sorted array.
func searchInRotatedArray(nums []int, target int) int {
	if len(nums) == 0 {
		return -1
	}
	pivot := findPivot(nums)
	if nums[pivot] <= target && target <= nums[len(nums) - 1] {
		return binarySearch(nums[pivot:], target) + pivot
	} else {
		return binarySearch(nums[:pivot], target)
	}
}

func main() {
	nums := []int{4, 5, 6, 7, 0, 1, 2}
	target := 0
	index := searchInRotatedArray(nums, target)
	if index != -1 {
		fmt.Printf("Target %d found at index %d\n", target, index)
	} else {
		fmt.Printf("Target %d not found in the array\n", target)
	}
}
```

## 2. Binary Search with Multiple Requirements

When searching for a target satisfying multiple requirements, you can modify the binary search to find the leftmost or rightmost occurrence of a target value.

### Example: Finding the Leftmost Occurrence

Here's how you can modify the binary search to find the leftmost occurrence of a target:

```go
package main

import (
	"fmt"
)

// findLeftmost performs a binary search to find the leftmost occurrence of the target.
func findLeftmost(nums []int, target int) int {
	low, high := 0, len(nums) - 1
	result := -1
	for low <= high {
		mid := low + (high - low) / 2
		if nums[mid] == target {
			result = mid
			high = mid - 1 // Move to the left part to find the leftmost occurrence.
		} else if nums[mid] < target {
			low = mid + 1
		} else {
			high = mid - 1
		}
	}
	return result
}

func main() {
	nums := []int{1, 2, 2, 2, 3, 4, 5}
	target := 2
	index := findLeftmost(nums, target)
	if index != -1 {
		fmt.Printf("Leftmost occurrence of target %d found at index %d\n", target, index)
	} else {
		fmt.Printf("Target %d not found in the array\n", target)
	}
}
```

#### Example: Finding the Rightmost Occurrence

Here's how you can modify the binary search to find the rightmost occurrence of a target:

```go
package main

import (
	"fmt"
)

// findRightmost performs a binary search to find the rightmost occurrence of the target.
func findRightmost(nums []int, target int) int {
	low, high := 0, len(nums) - 1
	result := -1
	for low <= high {
		mid := low + (high - low) / 2
		if nums[mid] == target {
			result = mid
			low = mid + 1 // Move to the right part to find the rightmost occurrence.
		} else if nums[mid] < target {
			low = mid + 1
		} else {
			high = mid - 1
		}
	}
	return result
}

func main() {
	nums := []int{1, 2, 2, 2, 3, 4, 5}
	target := 2
	index := findRightmost(nums, target)
	if index != -1 {
		fmt.Printf("Rightmost occurrence of target %d found at index %d\n", target, index)
	} else {
		fmt.Printf("Target %d not found in the array\n", target)
	}
}
```

### Summary

These variations of binary search adapt the basic algorithm to handle modified arrays or additional requirements. The key is to adjust the comparison logic and the movement of pointers (`low` and `high`) based on the specific scenario.
