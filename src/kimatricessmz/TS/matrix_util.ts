// File: matrix_util.ts

export function printMatrix(matrix: number[][]): void {
    matrix.forEach(row => {
        console.log(row.join(' '));
    });
}
