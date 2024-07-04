// palindrome.go
package main

import (
	"fmt"
)

func isPalindrome(s string) bool {
	left := 0
	right := len(s) - 1

	for left < right {
		if s[left] != s[right] {
			fmt.Println("The elements aren't the same, hence we return false")
			return false
		}

		left++  // Heading towards the right
		right-- // Heading towards the left
	}

	return true // We reached the middle of the string without finding a mismatch, so it is a palindrome.
}
