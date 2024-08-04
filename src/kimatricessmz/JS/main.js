const { setMatrixZeros } = require('./matrix');
const { printMatrix } = require('./matrix_util');

const matrices = [
    [[1, 1, 0], [1, 0, 1], [1, 1, 1]],
    [[1, 1, 1, 1, 1], [0, 0, 1, 1, 1], [1, 1, 1, 1, 0], [1, 1, 1, 1, 1]],
    [[3, 5, 2, 0], [1, 0, 4, 6], [7, 3, 2, 4]],
    [[1, 2, 3, 4], [4, 5, 6, 7], [8, 9, 4, 6]],
    [[2, 6, 5, 4, 9, 1], [7, 2, 0, 0, 5, 4], [1, 1, 1, 1, 0, 1], [9, 8, 2, 0, 1, 3], [7, 8, 6, 5, 4, 3], [9, 8, 1, 2, 5, 6]],
];

matrices.forEach((matrix, i) => {
    console.log(`${i + 1}. \tOriginal Matrix:`);
    printMatrix(matrix);
    const result = setMatrixZeros(matrix);
    console.log("\n\tMatrix with Zeros:");
    printMatrix(result);
    console.log('-'.repeat(100));
});
