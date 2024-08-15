# Cyclic Sort Pattern

## Missing Number

Let's improve and split your Go code into multiple files for better organization and maintainability.

### Directory Structure

Here's how we'll structure the project:

```text
missing-number/
│
├── main.go
├── missingnumber/
│   ├── find.go
│   └── find_test.go
└── go.mod
```

### `go.mod`

First, create a `go.mod` file to define your module:

```bash
go mod init missing-number
```

### `main.go`

This will be the entry point of your application.

```go
package main

import (
	"fmt"
	"strings"
	"missing-number/missingnumber"
)

func main() {
	inputNumbers := [][]int{
		{4, 0, 3, 1},
		{8, 3, 5, 2, 4, 6, 0, 1},
		{1, 2, 3, 4, 6, 7, 8, 9, 10, 5},
		{0},
		{1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23},
	}

	for i, x := range inputNumbers {
		fmt.Printf("%d.\tnums: %s\n", i+1, strings.Replace(fmt.Sprint(x), " ", ", ", -1))
		fmt.Printf("\n\tMissing number: %d\n", missingnumber.FindMissingNumber(x))
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
```

### `missingnumber/find.go`

This file will contain the core logic for finding the missing number.

```go
package missingnumber

func FindMissingNumber(nums []int) int {
	lenNums := len(nums)
	index := 0

	for index < lenNums {
		value := nums[index]

		if value < lenNums && value != nums[value] {
			nums[index], nums[value] = nums[value], nums[index]
			continue
		}
		index += 1
	}

	for i, x := range nums {
		if i != x {
			return i
		}
	}
	return lenNums
}
```

### `missingnumber/find_test.go`

This file contains unit tests for the `FindMissingNumber` function.

```go
package missingnumber

import "testing"

func TestFindMissingNumber(t *testing.T) {
	testCases := []struct {
		nums     []int
		expected int
	}{
		{[]int{4, 0, 3, 1}, 2},
		{[]int{8, 3, 5, 2, 4, 6, 0, 1}, 7},
		{[]int{1, 2, 3, 4, 6, 7, 8, 9, 10, 5}, 0},
		{[]int{0}, 1},
		{[]int{1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23}, 22},
	}

	for _, tc := range testCases {
		result := FindMissingNumber(tc.nums)
		if result != tc.expected {
			t.Errorf("For input %v, expected %d but got %d", tc.nums, tc.expected, result)
		}
	}
}
```

### Running the Code

1. **Run the main program**:

   ```bash
   go run main.go
   ```

2. **Run the tests**:
   ```bash
   go test ./missingnumber
   ```

This approach modularizes your code, making it easier to maintain and test each component separately.

The provided algorithm for finding the missing number using the Cyclic Sort pattern has a specific Big-O complexity. Let's break down the analysis.

### Time Complexity

1. **Cyclic Sort Loop (First While Loop):**

   - The first loop iterates over each element in the array. During each iteration, the algorithm checks if the current element is at its correct position. If it is not, it swaps the element with the one at the index equal to the element's value.
   - Each element is swapped at most once to reach its correct position.
   - The total number of operations is proportional to the number of elements in the array.
   - **Time Complexity:** \( O(n) \)

2. **Finding the Missing Number (Second For Loop):**
   - After the cyclic sort, the algorithm iterates over the array to find the index where the element does not match the index. This loop runs in linear time.
   - **Time Complexity:** \( O(n) \)

Since both loops run in linear time, the overall time complexity of the algorithm is:

**Overall Time Complexity:** \( O(n) \)

### Space Complexity

- The algorithm does not use any extra space apart from a few integer variables. It operates in-place, meaning it only modifies the input array.
- The space used is constant, regardless of the input size.

**Space Complexity:** \( O(1) \)

### Summary

- **Time Complexity:** \( O(n) \)
- **Space Complexity:** \( O(1) \)

This makes the algorithm efficient both in terms of time and space, which is ideal for this kind of problem.
