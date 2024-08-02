// File: Main.java

package com.example.main;

import com.example.bwmfinddifference.DifferenceFinder;

public class Main {
    public static void main(String[] args) {
        String[] string1List = {"wxyz", "cbda", "jlkmn", "courae", "hello"};
        String[] string2List = {"zwxgy", "abc", "klmn", "couearg", "helo"};

        for (int i = 0; i < string1List.length; i++) {
            System.out.printf("%d.\tString 1 = %s%n", i + 1, string1List[i]);
            System.out.printf("\tString 2 = %s%n", string2List[i]);
            System.out.printf("\n\tThe extra character is at index: %d%n", DifferenceFinder.extraCharacterIndex(string1List[i], string2List[i]));
            System.out.println("-".repeat(100));
        }
    }
}