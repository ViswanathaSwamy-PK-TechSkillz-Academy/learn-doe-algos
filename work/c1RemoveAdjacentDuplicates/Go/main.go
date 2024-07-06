package main

import (
	"fmt"
	"strings"
)

func removeDuplicates(s string) string {

	stack := []rune{}

	for _, char := range s {
		if len(stack) > 0 && stack[len(stack)-1] == char {
			stack = stack[:len(stack)-1] // pop the last element
		} else {
			stack = append(stack, char) // push the current character
		}
		fmt.Printf("\tStack: %s\n", string(stack))
	}

	return string(stack)
}

func main() {
	inputs := []string{
		"g",
		"ggaabcdeb",
		"abbddaccaaabcd",
		"aannkwwwkkkwna",
		"abbabccblkklu",
	}

	for i, input := range inputs {
		fmt.Printf("%d.\tRemove duplicates from string: \"%s\"\n", i+1, input)
		resultingString := removeDuplicates(input)
		fmt.Printf("\tString after removing duplicates: \"%s\"\n", resultingString)
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
