package main

import (
	"fmt"
	"strings"
)

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
