// File: Main.java

package src.main.com.example;

import java.util.Arrays;

import src.main.com.example.missingnumber.FindMissingNumber;

public class Main {

    public static void main(String[] args) {
        int[][] inputNumbers = {
                { 4, 0, 3, 1 },
                { 8, 3, 5, 2, 4, 6, 0, 1 },
                { 1, 2, 3, 4, 6, 7, 8, 9, 10, 5 },
                { 0 },
                { 1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23 }
        };

        FindMissingNumber finder = new FindMissingNumber();

        for (int i = 0; i < inputNumbers.length; i++) {
            int[] nums = inputNumbers[i];
            int missingNumber = finder.findMissingNumber(nums);

            System.out.printf("%d.\tnums: %s%n", i + 1, Arrays.toString(nums));
            System.out.printf("\tMissing number: %d%n", missingNumber);
            System.out.println("-".repeat(100));
        }
    }
}
