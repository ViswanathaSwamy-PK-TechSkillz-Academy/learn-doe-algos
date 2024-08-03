// File: matrix_util.js

function printMatrix(matrix) {
    matrix.forEach(row => {
        console.log(row.join(' '));
    });
}

module.exports = { printMatrix };
