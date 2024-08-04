# File: main.py

from matrix import set_matrix_zeros
from matrix_util import print_matrix

matrices = [
    [[1, 1, 0], [1, 0, 1], [1, 1, 1]],
    [[1, 1, 1, 1, 1], [0, 0, 1, 1, 1], [1, 1, 1, 1, 0], [1, 1, 1, 1, 1]],
    [[3, 5, 2, 0], [1, 0, 4, 6], [7, 3, 2, 4]],
    [[1, 2, 3, 4], [4, 5, 6, 7], [8, 9, 4, 6]],
    [[2, 6, 5, 4, 9, 1], [7, 2, 0, 0, 5, 4], [1, 1, 1, 1, 0, 1], [
        9, 8, 2, 0, 1, 3], [7, 8, 6, 5, 4, 3], [9, 8, 1, 2, 5, 6]],
]

for i, matrix in enumerate(matrices):
    print(f"{i + 1}. \tOriginal Matrix:")
    print_matrix(matrix)
    result = set_matrix_zeros(matrix)
    print("\n\tMatrix with Zeros:")
    print_matrix(result)
    print('-' * 100)
