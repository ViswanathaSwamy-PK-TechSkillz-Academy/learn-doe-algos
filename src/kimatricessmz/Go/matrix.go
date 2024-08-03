// File: matrix.go

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
