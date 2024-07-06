// main.go

package main

import (
	"fmt"
	"strings"
)

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
