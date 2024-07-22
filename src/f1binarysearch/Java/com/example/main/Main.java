package com.example.main;

import com.example.jbinarysearch.BinarySearch;

public class Main {
    public static void main(String[] args) {
        int[][] numsLists = {
                {},
                { 0, 1 },
                { 1, 2, 3 },
                { -1, 0, 3, 5, 9, 12 },
                { -100, -67, -55, -50, -49, -40, -33, -22, -10, -5 },
        };

        int[] targetList = { 12, 1, 3, 9, -22 };

        for (int i = 0; i < numsLists.length; i++) {
            int[] nums = numsLists[i];
            int target = targetList[i];
            int index = BinarySearch.search(nums, target);

            System.out.println((i + 1) + ".\tArray to search: " + arrayToString(nums));
            System.out.println("\tTarget: " + target);

            if (index != -1) {
                System.out.println("\t" + target + " exists in the array at index " + index);
            } else {
                System.out.println("\t" + target + " does not exist in the array, so the return value is " + index);
            }

            System.out.println("-".repeat(100));
        }
    }

    private static String arrayToString(int[] array) {
        if (array.length == 0)
            return "[]";
        StringBuilder sb = new StringBuilder();
        sb.append("[");
        for (int i = 0; i < array.length; i++) {
            sb.append(array[i]);
            if (i < array.length - 1)
                sb.append(", ");
        }
        sb.append("]");
        return sb.toString();
    }
}