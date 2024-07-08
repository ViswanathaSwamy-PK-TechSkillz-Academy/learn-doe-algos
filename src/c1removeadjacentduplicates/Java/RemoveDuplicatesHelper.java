package c1removeadjacentduplicates.Java;

import java.util.Stack;

public class RemoveDuplicatesHelper {
    public static String removeDuplicates(String s) {
        Stack<Character> stack = new Stack<>();

        for (char c : s.toCharArray()) {
            if (!stack.isEmpty() && stack.peek() == c) {
                stack.pop(); // pop the last element
            } else {
                stack.push(c); // push the current character
            }
        }

        // Convert stack to string
        StringBuilder result = new StringBuilder();
        while (!stack.isEmpty()) {
            result.insert(0, stack.pop()); // Stack needs to be reversed to get correct order
        }
        return result.toString();
    }
}
