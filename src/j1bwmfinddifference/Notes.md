# Bitwise Manipulation

## Find the Difference

To solve this problem using bitwise manipulation in Go, we'll use the XOR operation to identify the extra character. By XOR-ing all characters in both strings, we can isolate the extra character, because XOR-ing two identical characters results in 0, and XOR-ing 0 with any character results in the character itself.

Here’s how you can organize the Go code into multiple files:

1. **main.go**: This file will contain the main function that reads the input strings and calls the function to find the index of the extra character.
2. **find_difference.go**: This file will contain the logic to find the extra character and its index.

### File: `main.go`

```go
package main

import (
	"fmt"
)

func main() {
	// Example input strings
	str1 := "abcdefg"
	str2 := "abcdefh"

	// Find the index of the extra character
	index := FindDifferenceIndex(str1, str2)
	fmt.Printf("The index of the extra character is: %d\n", index)
}
```

### File: `find_difference.go`

```go
package main

// FindDifferenceIndex finds the index of the extra character that is present in only one of the strings.
// It assumes that one string has exactly one extra character compared to the other.
func FindDifferenceIndex(str1, str2 string) int {
	longer, shorter := str1, str2
	if len(str2) > len(str1) {
		longer, shorter = str2, str1
	}

	// XOR all characters in both strings to find the extra character
	var extraChar byte
	for i := range longer {
		if i < len(shorter) {
			extraChar ^= longer[i] ^ shorter[i]
		} else {
			extraChar ^= longer[i]
		}
	}

	// Find the index of the extra character in the longer string
	for i := range longer {
		if longer[i] == extraChar {
			return i
		}
	}

	return -1 // This should never happen if the input is as expected
}
```

### Explanation

1. **main.go**:

   - The `main` function initializes two example strings (`str1` and `str2`).
   - It calls the `FindDifferenceIndex` function with these strings and prints the result.

2. **find_difference.go**:
   - The `FindDifferenceIndex` function first determines which string is longer.
   - It then uses the XOR operation to find the extra character.
   - Finally, it iterates through the longer string to find and return the index of the extra character.

This implementation assumes that one string has exactly one extra character compared to the other, as stated in the problem. If the input guarantees are different, additional error handling might be necessary.
