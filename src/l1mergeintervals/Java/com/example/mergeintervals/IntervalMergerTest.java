package com.example.mergeintervals;

import java.util.Arrays;

public class IntervalMergerTest {
    public static void main(String[] args) {
        int[][][] testCases = {
                { { 1, 5 }, { 3, 7 }, { 4, 6 } },
                { { 1, 5 }, { 4, 6 }, { 6, 8 }, { 11, 15 } },
                { { 3, 7 }, { 6, 8 }, { 10, 12 }, { 11, 15 } },
                { { 1, 5 } },
                { { 1, 9 }, { 3, 8 }, { 4, 4 } },
                { { 1, 2 }, { 3, 4 }, { 8, 8 } },
                { { 1, 5 }, { 1, 3 } },
                { { 1, 5 }, { 6, 9 } },
                { { 0, 0 }, { 1, 18 }, { 1, 3 } }
        };

        int[][][] expectedResults = {
                { { 1, 7 } },
                { { 1, 8 }, { 11, 15 } },
                { { 3, 8 }, { 10, 15 } },
                { { 1, 5 } },
                { { 1, 9 } },
                { { 1, 2 }, { 3, 4 }, { 8, 8 } },
                { { 1, 5 } },
                { { 1, 5 }, { 6, 9 } },
                { { 0, 0 }, { 1, 18 } }
        };

        for (int i = 0; i < testCases.length; i++) {
            int[][] result = IntervalMerger.mergeIntervals(testCases[i]);
            if (!Arrays.deepEquals(result, expectedResults[i])) {
                System.out.println("Test failed: expected " + Arrays.deepToString(expectedResults[i]) + ", but got "
                        + Arrays.deepToString(result));
            } else {
                System.out.println("Test passed.");
            }
        }
    }
}
