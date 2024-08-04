# File: matrix.py

from typing import List


def set_matrix_zeros(mat: List[List[int]]) -> List[List[int]]:
    rows = len(mat)
    cols = len(mat[0])
    first_col_zero = False
    first_row_zero = False

    # Check if the first column contains any zeros
    for i in range(rows):
        if mat[i][0] == 0:
            first_col_zero = True
            break

    # Check if the first row contains any zeros
    for j in range(cols):
        if mat[0][j] == 0:
            first_row_zero = True
            break

    # Use the first row and column to mark zeros
    for i in range(1, rows):
        for j in range(1, cols):
            if mat[i][j] == 0:
                mat[0][j] = 0
                mat[i][0] = 0

    # Zero out cells based on the marks in the first row and column
    for i in range(1, rows):
        if mat[i][0] == 0:
            for j in range(1, cols):
                mat[i][j] = 0

    for j in range(1, cols):
        if mat[0][j] == 0:
            for i in range(1, rows):
                mat[i][j] = 0

    # Zero out the first column if necessary
    if first_col_zero:
        for i in range(rows):
            mat[i][0] = 0

    # Zero out the first row if necessary
    if first_row_zero:
        for j in range(cols):
            mat[0][j] = 0

    return mat
