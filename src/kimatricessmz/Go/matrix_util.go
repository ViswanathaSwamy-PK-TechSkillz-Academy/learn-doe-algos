// File: matrix_util.go

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
