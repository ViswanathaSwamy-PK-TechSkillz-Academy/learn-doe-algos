// PalindromePermutation.java
package com.example.palindrome;

import java.util.HashMap;
import java.util.Map;

public class PalindromePermutation {
    public static boolean canPermutePalindrome(String s) {
        Map<Character, Integer> charCount = new HashMap<>();

        for (char c : s.toCharArray()) {
            charCount.put(c, charCount.getOrDefault(c, 0) + 1);
        }

        int oddCount = 0;
        for (int count : charCount.values()) {
            if (count % 2 != 0) {
                oddCount++;
            }

            if (oddCount > 1) {
                return false;
            }
        }

        return true;
    }
}
