// File: Main.java

package com.example.main;

import com.example.matricessmz.*;

public class Main {
    public static void main(String[] args) {
        int[][][] matrices = {
                { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 1 } },
                { { 1, 1, 1, 1, 1 }, { 0, 0, 1, 1, 1 }, { 1, 1, 1, 1, 0 }, { 1, 1, 1, 1, 1 } },
                { { 3, 5, 2, 0 }, { 1, 0, 4, 6 }, { 7, 3, 2, 4 } },
                { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 8, 9, 4, 6 } },
                { { 2, 6, 5, 4, 9, 1 }, { 7, 2, 0, 0, 5, 4 }, { 1, 1, 1, 1, 0, 1 }, { 9, 8, 2, 0, 1, 3 },
                        { 7, 8, 6, 5, 4, 3 }, { 9, 8, 1, 2, 5, 6 } }
        };

        for (int i = 0; i < matrices.length; i++) {
            System.out.println((i + 1) + ". \tOriginal Matrix:");
            MatrixUtil.printMatrix(matrices[i]);
            int[][] result = Matrix.setMatrixZeros(matrices[i]);
            System.out.println("\n\tMatrix with Zeros:");
            MatrixUtil.printMatrix(result);
            System.out.println("-".repeat(100));
        }
    }
}
