// File: matrix.js

function setMatrixZeros(mat) {
    const rows = mat.length;
    const cols = mat[0].length;
    let firstColZero = false;
    let firstRowZero = false;

    // Check if the first column contains any zeros
    for (let i = 0; i < rows; i++) {
        if (mat[i][0] === 0) {
            firstColZero = true;
            break;
        }
    }

    // Check if the first row contains any zeros
    for (let j = 0; j < cols; j++) {
        if (mat[0][j] === 0) {
            firstRowZero = true;
            break;
        }
    }

    // Use the first row and column to mark zeros
    for (let i = 1; i < rows; i++) {
        for (let j = 1; j < cols; j++) {
            if (mat[i][j] === 0) {
                mat[0][j] = 0;
                mat[i][0] = 0;
            }
        }
    }

    // Zero out cells based on the marks in the first row and column
    for (let i = 1; i < rows; i++) {
        if (mat[i][0] === 0) {
            for (let j = 1; j < cols; j++) {
                mat[i][j] = 0;
            }
        }
    }

    for (let j = 1; j < cols; j++) {
        if (mat[0][j] === 0) {
            for (let i = 1; i < rows; i++) {
                mat[i][j] = 0;
            }
        }
    }

    // Zero out the first column if necessary
    if (firstColZero) {
        for (let i = 0; i < rows; i++) {
            mat[i][0] = 0;
        }
    }

    // Zero out the first row if necessary
    if (firstRowZero) {
        for (let j = 0; j < cols; j++) {
            mat[0][j] = 0;
        }
    }

    return mat;
}

module.exports = { setMatrixZeros };
