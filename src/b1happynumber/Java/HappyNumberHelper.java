import java.util.HashSet;

public class HappyNumberHelper {

    // Helper function that calculates the sum of squared digits
    private static int sumOfSquaredDigits(int number) {
        int totalSum = 0;
        while (number > 0) {
            int digit = number % 10;
            number /= 10;
            totalSum += digit * digit;
        }
        return totalSum;
    }

    // Function to check if a number is a happy number
    public static boolean isHappyNumber(int n) {
        HashSet<Integer> seen = new HashSet<>();

        while (n != 1 && !seen.contains(n)) {
            seen.add(n);
            n = sumOfSquaredDigits(n);
        }

        return n == 1;
    }
}
