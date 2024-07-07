// Helper function that calculates the sum of squared digits
export function sumOfSquaredDigits(number: number): number {
    let totalSum = 0;
    while (number > 0) {
        const digit = number % 10;
        number = Math.floor(number / 10);
        totalSum += digit * digit;
    }
    return totalSum;
}

// Function to check if a number is a happy number
export function isHappyNumber(n: number): boolean {
    let seen = new Set<number>();

    while (n !== 1 && !seen.has(n)) {
        seen.add(n);
        n = sumOfSquaredDigits(n);
    }

    return n === 1;
}
