// happyNumberHelper.js

// Helper function that calculates the sum of squared digits.
function sumOfSquaredDigits(number) {
    let totalSum = 0;

    while (number > 0) {
        const digit = number % 10; // Extract the digit before division
        number = Math.floor(number / 10); // Update the number
        totalSum += digit * digit;
    }

    return totalSum;
}

// Function to check if a number is a happy number
function isHappyNumber(n) {
    let slow = n;
    let fast = sumOfSquaredDigits(n);

    while (fast !== 1 && slow !== fast) {
        slow = sumOfSquaredDigits(slow);
        fast = sumOfSquaredDigits(sumOfSquaredDigits(fast));
    }

    return fast === 1;
}

module.exports = { sumOfSquaredDigits, isHappyNumber };
