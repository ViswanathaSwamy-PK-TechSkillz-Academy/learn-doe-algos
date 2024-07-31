package main

import (
	"fmt"
	"strings"
)

func main() {
	// Example input strings
	string1List := []string{"wxyz", "cbda", "jlkmn", "courae", "hello"}
	string2List := []string{"zwxgy", "abc", "klmn", "couearg", "helo"}

	for i := 0; i < len(string1List); i++ {
		fmt.Printf("%d.\tString 1 = %s\n", i+1, string1List[i])
		fmt.Printf("\tString 2 = %s\n", string2List[i])
		fmt.Printf("\n\tThe extra character is at index: %d\n", extraCharacterIndex(string1List[i], string2List[i]))
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
