# File: matrix_util.py

from typing import List


def print_matrix(matrix: List[List[int]]) -> None:
    for row in matrix:
        print(' '.join(map(str, row)))
