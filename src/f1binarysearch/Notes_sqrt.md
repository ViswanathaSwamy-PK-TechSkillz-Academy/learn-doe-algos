# Sqrt

## To find the integer square root of a positive number \( x \), you can use a binary search approach. The idea is to search for the largest integer \( y \) such that \( y^2 \leq x \). Here's how you can implement this in Go:

### Implementation

```go
package main

import (
	"fmt"
)

// sqrt calculates the integer square root of a positive number x.
func sqrt(x int) int {
	if x < 2 {
		return x
	}

	low, high := 0, x
	var mid int
	for low <= high {
		mid = low + (high - low) / 2
		midSquared := mid * mid
		if midSquared == x {
			return mid
		} else if midSquared < x {
			low = mid + 1
		} else {
			high = mid - 1
		}
	}

	return high
}

func main() {
	numbers := []int{0, 1, 4, 8, 10, 15, 16, 25, 26, 100, 1000}
	for _, num := range numbers {
		fmt.Printf("The integer square root of %d is %d\n", num, sqrt(num))
	}
}
```

### Explanation

1. **Base Cases**:

   - If \( x \) is less than 2, return \( x \) directly because the square root of 0 is 0, and the square root of 1 is 1.

2. **Binary Search**:

   - Initialize `low` to 0 and `high` to \( x \).
   - While `low` is less than or equal to `high`, calculate the middle point `mid`.
   - Calculate `midSquared` as \( \text{mid} \times \text{mid} \).
   - If `midSquared` is equal to \( x \), return `mid` because it is the exact integer square root.
   - If `midSquared` is less than \( x \), adjust `low` to `mid + 1` to search in the right half.
   - If `midSquared` is greater than \( x \), adjust `high` to `mid - 1` to search in the left half.

3. **Return Value**:
   - After the loop, `high` will be the largest integer such that \( \text{high}^2 \leq x \).

### Test Cases

In the `main` function, the algorithm is tested with several numbers, including edge cases like 0 and 1, perfect squares like 4, 16, and 25, and non-perfect squares like 8, 10, and 15. This ensures the function works correctly across a range of inputs.

### Running the Code

To run this code, save it to a `.go` file (e.g., `sqrt.go`) and execute it using the `go run` command:

```sh
go run sqrt.go
```

This will print the integer square roots of the specified numbers, demonstrating the correctness of the implementation.
