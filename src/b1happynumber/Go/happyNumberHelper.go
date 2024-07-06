// happyNumberHelper.go

package main

// Helper function that calculates the sum of squared digits.
func sumOfSquaredDigits(number int) int {
	totalSum := 0

	for number > 0 {
		digit := number % 10 // Extract the digit before division
		number = number / 10 // Update the number
		totalSum += digit * digit
	}

	return totalSum
}

// Function to check if a number is a happy number
func isHappyNumber(n int) bool {
	slow := n
	fast := sumOfSquaredDigits(n)

	for fast != 1 && slow != fast {
		slow = sumOfSquaredDigits(slow)
		fast = sumOfSquaredDigits(sumOfSquaredDigits(fast))
	}

	return fast == 1
}
