// File: main.go

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
