package com.example.main;

import com.example.kwaymerge.MergeSorted;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        int[][] nums1 = {
                { 23, 33, 35, 41, 44, 47, 56, 91, 105, 0, 0, 0, 0, 0, 0 },
                { 1, 2, 0 },
                { 1, 1, 1, 0, 0, 0, 0 },
                { 6, 0, 0 },
                { 12, 34, 45, 56, 67, 78, 89, 99, 0 },
        };

        int[][] nums2 = {
                { 32, 49, 50, 51, 61, 99 },
                { 7 },
                { 1, 2, 3, 4 },
                { -99, -45 },
                { 100 },
        };

        int[] m = { 9, 2, 3, 1, 8 };
        int[] n = { 6, 1, 4, 2, 1 };

        for (int index = 0; index < m.length; index++) {
            System.out.printf("%d.\tnums1: %s, m: %d\n", index + 1, Arrays.toString(nums1[index]), m[index]);
            System.out.printf("\tnums2: %s, n: %d\n", Arrays.toString(nums2[index]), n[index]);
            int[] result = MergeSorted.merge(nums1[index], m[index], nums2[index], n[index]);
            System.out.printf("\tMerged list: %s\n", Arrays.toString(result));
            System.out.println("-".repeat(100));
        }
    }
}
