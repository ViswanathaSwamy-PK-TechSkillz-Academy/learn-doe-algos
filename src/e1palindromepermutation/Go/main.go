// main.go
package main

import "fmt"

func main() {
	testCases := []string{
		"code", "aab", "carerac", "racecar", "hello",
		"baefeab", "abc", "xzz", "jjadd", "kllk",
	}

	for _, testCase := range testCases {
		fmt.Printf("Can \"%s\" form a palindrome permutation? %v\n", testCase, permutePalindrome(testCase))
	}
}
