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
