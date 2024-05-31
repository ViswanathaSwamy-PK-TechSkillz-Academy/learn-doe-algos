package main

import (
	"fmt"
	"strings"
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

func main() {
	testCases := []string{"RACEACAR", "A", "ABCDEFGFEDCBA", "ABC", "ABCBA", "ABBA", "RACEACAR"}
	i := 1

	for _, s := range testCases {
		fmt.Printf("Test Case #%d\n", i)
		fmt.Println("-" + strings.Repeat("-", 99))
		fmt.Printf("The input string is '%s' and the length of the string is %d.\n", s, len(s))
		fmt.Printf("\nIs it a palindrome?..... %v\n", isPalindrome(s))
		fmt.Println("-" + strings.Repeat("-", 99))
		i++
	}
}
