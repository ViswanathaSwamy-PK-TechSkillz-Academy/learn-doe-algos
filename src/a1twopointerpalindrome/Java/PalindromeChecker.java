import java.util.Arrays;
import java.util.List;

public class PalindromeChecker {

    public static boolean isPalindrome(String s) {
        int left = 0;
        int right = s.length() - 1;

        while (left < right) {
            if (s.charAt(left) != s.charAt(right)) {
                System.out.println("The elements aren't the same, hence we return false");
                return false;
            }

            left++; // Heading towards the right
            right--; // Heading towards the left
        }

        return true; // We reached the middle of the string without finding a mismatch, so it is a
                     // palindrome.
    }

    public static void main(String[] args) {
        List<String> testCases = Arrays.asList("RACEACAR", "A", "ABCDEFGFEDCBA", "ABC", "ABCBA", "ABBA", "RACEACAR");
        int i = 1;

        for (String s : testCases) {
            System.out.printf("Test Case #%d%n", i);
            System.out.println("-".repeat(100));
            System.out.printf("The input string is '%s' and the length of the string is %d.%n", s, s.length());
            System.out.printf("%nIs it a palindrome?..... %b%n", isPalindrome(s));
            System.out.println("-".repeat(100));
            i++;
        }
    }
}
