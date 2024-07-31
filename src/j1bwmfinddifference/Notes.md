# Bitwise Manipulation

## Find the Difference

### File: `main.go`

```go
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
```

### File: `find_difference.go`

```go
package main

import (
	"strings"
)

// extraCharacterIndex finds the index of the extra character that is present in only one of the strings.
// It assumes that one string has exactly one extra character compared to the other.
func extraCharacterIndex(str1, str2 string) int {
	result := 0
	str1Length := len(str1)
	str2Length := len(str2)

	// XOR all characters in str1
	for i := 0; i < str1Length; i++ {
		result ^= int(str1[i])
	}

	// XOR all characters in str2
	for i := 0; i < str2Length; i++ {
		result ^= int(str2[i])
	}

	// Determine the longer string and find the index of the extra character
	if str1Length > str2Length {
		index := strings.Index(str1, string(result))
		return index
	} else {
		index := strings.Index(str2, string(result))
		return index
	}
}
```

### Explanation

1. **main.go**:

   - Contains the `main` function that initializes lists of string pairs.
   - Iterates over these lists, calling the `extraCharacterIndex` function for each pair.
   - Prints the strings and the index of the extra character.

2. **find_difference.go**:
   - Contains the `extraCharacterIndex` function which uses XOR to find the extra character.
   - It iterates through both strings, XOR-ing all characters.
   - It then determines which string is longer and finds the index of the extra character in that string using `strings.Index`.

This structure separates the main logic from the function, making the code cleaner and more modular. You can now compile and run these files together to see the result.
