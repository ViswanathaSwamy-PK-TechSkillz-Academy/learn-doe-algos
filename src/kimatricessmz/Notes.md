# Matrices

Let's refactor the provided code into multiple files and enhance it by separating concerns, adding comments, and improving readability.

## Set Matrix Zeros

We'll create three files:

1. `main.go`: The entry point of the application.
2. `matrix.go`: Contains the matrix processing logic.
3. `matrix_util.go`: Contains utility functions for matrix operations (like printing).

Here's the refactored code:

### `main.go`

```go
package main

import (
	"fmt"
	"strings"
)

func main() {
	// Sample matrices to test the function
	matrices := [][][]int{
		{{1, 1, 0}, {1, 0, 1}, {1, 1, 1}},
		{{1, 1, 1, 1, 1}, {0, 0, 1, 1, 1}, {1, 1, 1, 1, 0}, {1, 1, 1, 1, 1}},
		{{3, 5, 2, 0}, {1, 0, 4, 6}, {7, 3, 2, 4}},
		{{1, 2, 3, 4}, {4, 5, 6, 7}, {8, 9, 4, 6}},
		{{2, 6, 5, 4, 9, 1}, {7, 2, 0, 0, 5, 4}, {1, 1, 1, 1, 0, 1}, {9, 8, 2, 0, 1, 3}, {7, 8, 6, 5, 4, 3}, {9, 8, 1, 2, 5, 6}},
	}

	// Process each matrix and print the results
	for i, matrix := range matrices {
		fmt.Printf("%d. \tOriginal Matrix:\n", i+1)
		PrintMatrix(matrix)
		result := SetMatrixZeros(matrix)
		fmt.Println("\n\tMatrix with Zeros:")
		PrintMatrix(result)
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
```

### `matrix.go`

```go
package main

// SetMatrixZeros sets entire rows and columns to zero if any element within the matrix is zero.
func SetMatrixZeros(mat [][]int) [][]int {
	rows := len(mat)
	cols := len(mat[0])
	firstColZero := false
	firstRowZero := false

	// Check if the first column contains any zeros
	for i := 0; i < rows; i++ {
		if mat[i][0] == 0 {
			firstColZero = true
			break
		}
	}

	// Check if the first row contains any zeros
	for j := 0; j < cols; j++ {
		if mat[0][j] == 0 {
			firstRowZero = true
			break
		}
	}

	// Use the first row and column to mark zeros
	for i := 1; i < rows; i++ {
		for j := 1; j < cols; j++ {
			if mat[i][j] == 0 {
				mat[0][j] = 0
				mat[i][0] = 0
			}
		}
	}

	// Zero out cells based on the marks in the first row and column
	for i := 1; i < rows; i++ {
		if mat[i][0] == 0 {
			for j := 1; j < cols; j++ {
				mat[i][j] = 0
			}
		}
	}

	for j := 1; j < cols; j++ {
		if mat[0][j] == 0 {
			for i := 1; i < rows; i++ {
				mat[i][j] = 0
			}
		}
	}

	// Zero out the first column if necessary
	if firstColZero {
		for i := 0; i < rows; i++ {
			mat[i][0] = 0
		}
	}

	// Zero out the first row if necessary
	if firstRowZero {
		for j := 0; j < cols; j++ {
			mat[0][j] = 0
		}
	}

	return mat
}
```

### `matrix_util.go`

```go
package main

import "fmt"

// PrintMatrix prints the matrix for debugging purposes
func PrintMatrix(matrix [][]int) {
	for _, row := range matrix {
		for _, val := range row {
			fmt.Printf("%d ", val)
		}
		fmt.Println()
	}
}
```

### Explanation

- `main.go`: This file contains the entry point of the application. It initializes sample matrices, processes them using the `SetMatrixZeros` function, and prints the results.
- `matrix.go`: This file contains the `SetMatrixZeros` function, which is responsible for setting entire rows and columns to zero if any element within the matrix is zero.
- `matrix_util.go`: This file contains the `PrintMatrix` function, which is a utility function for printing matrices. This separation of concerns makes the code more modular and easier to maintain.

You can compile and run this Go program by navigating to the directory containing these files and running the following command:

```sh
go run main.go matrix.go matrix_util.go
```
