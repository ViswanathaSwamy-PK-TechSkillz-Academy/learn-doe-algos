package main

import (
	"fmt"
	"strings"
)

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

func main() {
	inputs := []int{1, 5, 19, 25, 7}
	for i, input := range inputs {
		fmt.Printf("%d.\tInput Number: %d\n", i+1, input)

		result := "False"
		if isHappyNumber(input) {
			result = "True"
		}

		fmt.Printf("\n\tIs it a happy number? %s\n", result)
		fmt.Println("-" + strings.Repeat("-", 99))
	}
}
