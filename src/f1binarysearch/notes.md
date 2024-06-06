# Binary Search

### binary_search.go

This file defines the `binarySearch` function which performs a binary search on a sorted slice of integers.

```go
package main

// binarySearch performs a binary search on a sorted slice of integers.
// It returns the index of the target if found, or -1 if the target is not in the slice.
func binarySearch(nums []int, target int) int {
    low := 0
    high := len(nums) - 1

    for low <= high {
        mid := low + (high-low)/2
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
```

### Explanation

1. **Package Declaration**:

   - `package main`: Declares that this file is part of the main package.

2. **binarySearch Function**:

   - `func binarySearch(nums []int, target int) int`: Defines a function named `binarySearch` that takes a slice of integers `nums` and an integer `target`. It returns an integer which is the index of the target if found, or -1 if the target is not in the slice.
   - Inside the function:
     - `low := 0` and `high := len(nums) - 1`: Initializes two pointers, `low` and `high`, representing the current range of the search.
     - `for low <= high { ... }`: A loop that continues as long as `low` is less than or equal to `high`.
     - `mid := low + (high-low)/2`: Calculates the midpoint of the current range to avoid potential overflow issues.
     - `if nums[mid] == target { return mid }`: Checks if the midpoint value is the target and returns the index if true.
     - `if target < nums[mid] { high = mid - 1 } else { low = mid + 1 }`: Adjusts the search range based on the comparison of the midpoint value with the target.

### main.go

This file defines the `main` function to test the `binarySearch` function with various test cases.

Sure, here's the modified `main.go` file based on your requirements:

```go
package main

import (
    "fmt"
    "strings"
)

func main() {
    numsLists := [][]int{
        {},
        {0, 1},
        {1, 2, 3},
        {-1, 0, 3, 5, 9, 12},
        {-100, -67, -55, -50, -49, -40, -33, -22, -10, -5},
    }

    targetList := []int{12, 1, 3, 9, -22}

    for i := 0; i < len(numsLists); i++ {
        nums := numsLists[i]
        target := targetList[i]
        index := binarySearch(nums, target)

        fmt.Printf("%d.\tArray to search: %v\n", i+1, strings.Replace(fmt.Sprint(nums), " ", ", ", -1))
        fmt.Printf("\tTarget: %d\n", target)

        if index != -1 {
            fmt.Printf("\t%d exists in the slice at index %d\n", target, index)
        } else {
            fmt.Printf("\t%d does not exist in the slice, so the return value is %d\n", target, index)
        }

        fmt.Println(strings.Repeat("-", 100))
    }
}
```

### Explanation

1. **Package Declaration**:

   - `package main`: Declares that this file is part of the main package.

2. **Imports**:

   - `import "fmt"`: Imports the `fmt` package for formatted I/O.
   - `import "strings"`: Imports the `strings` package for string manipulation.

3. **main Function**:

   - `func main()`: Defines the `main` function which is the entry point of the program.
   - Inside the function:
     - `numsLists := [][]int{ ... }`: Initializes a slice of slices of integers to be searched.
     - `targetList := []int{ ... }`: Initializes a slice of integers which are the targets to be searched for in the respective slices in `numsLists`.
     - `for i := 0; i < len(numsLists); i++ { ... }`: Iterates through each slice in `numsLists` and the corresponding target in `targetList`.
     - `nums := numsLists[i]`: Gets the current slice of integers.
     - `target := targetList[i]`: Gets the current target integer.
     - `index := binarySearch(nums, target)`: Calls the `binarySearch` function with the current slice and target.
     - `fmt.Printf("%d.\tArray to search: %v\n", i+1, strings.Replace(fmt.Sprint(nums), " ", ", ", -1))`: Prints the current slice of integers with elements separated by commas.
     - `fmt.Printf("\tTarget: %d\n", target)`: Prints the current target integer.
     - `if index != -1 { fmt.Printf("\t%d exists in the slice at index %d\n", target, index) } else { fmt.Printf("\t%d does not exist in the slice, so the return value is %d\n", target, index) }`: Prints whether the target exists in the slice and its index, or indicates that the target was not found and prints `-1`.
     - `fmt.Println(strings.Repeat("-", 100))`: Prints a line of dashes for visual separation between test cases.

### How the Code Works Together

- The `binary_search.go` file defines the `binarySearch` function which performs the binary search algorithm on a sorted slice of integers.
- The `main.go` file tests the `binarySearch` function with various target values and prints the results.
- The `main` function in `main.go` initializes test cases, calls the `binarySearch` function for each case, and outputs whether the target was found and at what index.
