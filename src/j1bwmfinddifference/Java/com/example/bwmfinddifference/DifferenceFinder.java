// File: DifferenceFinder.java

package com.example.bwmfinddifference;

public class DifferenceFinder {
    public static int extraCharacterIndex(String str1, String str2) {
        int result = 0;

        for (int i = 0; i < str1.length(); i++) {
            result ^= str1.charAt(i);
        }

        for (int i = 0; i < str2.length(); i++) {
            result ^= str2.charAt(i);
        }

        return str1.length() > str2.length() ? str1.indexOf((char)result) : str2.indexOf((char)result);
    }
}