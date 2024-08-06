package com.example.main;

import java.util.Arrays;
import java.util.List;
import com.example.mergeintervals.*;

public class Main {
    public static void main(String[] args) {
        List<int[][]> inputList = Arrays.asList(
                new int[][] { { 1, 5 }, { 3, 7 }, { 4, 6 } },
                new int[][] { { 1, 5 }, { 4, 6 }, { 6, 8 }, { 11, 15 } },
                new int[][] { { 3, 7 }, { 6, 8 }, { 10, 12 }, { 11, 15 } },
                new int[][] { { 1, 5 } },
                new int[][] { { 1, 9 }, { 3, 8 }, { 4, 4 } },
                new int[][] { { 1, 2 }, { 3, 4 }, { 8, 8 } },
                new int[][] { { 1, 5 }, { 1, 3 } },
                new int[][] { { 1, 5 }, { 6, 9 } },
                new int[][] { { 0, 0 }, { 1, 18 }, { 1, 3 } });

        for (int i = 0; i < inputList.size(); i++) {
            System.out.println((i + 1) + ". Intervals to merge: " + Arrays.deepToString(inputList.get(i)));
            int[][] result = IntervalMerger.mergeIntervals(inputList.get(i));
            System.out.println("Merged intervals: " + Arrays.deepToString(result));
            System.out.println("-".repeat(100));
        }
    }
}
