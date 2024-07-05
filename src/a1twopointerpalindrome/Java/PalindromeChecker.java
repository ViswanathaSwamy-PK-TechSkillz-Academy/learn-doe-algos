// PalindromeChecker.java
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

        return true; // We reached the middle of the string without finding a mismatch, so it is a palindrome.
    }
}
