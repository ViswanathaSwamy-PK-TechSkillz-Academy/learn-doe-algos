// Helper function that calculates the sum of squared digits.
function sumOfSquaredDigits(number) {
    let totalSum = 0;

    while (number > 0) {
        let digit = number % 10; // Extract the digit before division
        number = Math.floor(number / 10); // Update the number
        totalSum += digit ** 2;
    }

    return totalSum;
}

module.exports = sumOfSquaredDigits;
