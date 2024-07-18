// Main.java
package com.example.main;

import com.example.palindrome.PalindromePermutation;

public class Main {
    public static void main(String[] args) {
        String[] testCases = {
            "code", "aab", "carerac", "racecar", "hello",
            "baefeab", "abc", "xzz", "jjadd", "kllk"
        };

        for (String testCase : testCases) {
            System.out.println("Can \"" + testCase + "\" form a palindrome permutation? " 
                + PalindromePermutation.canPermutePalindrome(testCase));
        }
    }
}
