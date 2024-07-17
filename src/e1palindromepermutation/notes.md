# Palindrome Permutations

## populating_hashmap.go

This file defines the `Hashmap` struct and its methods.

```go
package main

type Hashmap struct {
    hashmap map[string]int
}

func (this *Hashmap) Insert(x string) {
    if _, ok := this.hashmap[x]; ok {
        this.hashmap[x] += 1
    } else {
        this.hashmap[x] = 1
    }
}
```

### Explanation

1. **Package Declaration**:

   - `package main`: Declares that this file is part of the main package.

2. **Hashmap Struct**:

   - `type Hashmap struct { hashmap map[string]int }`: Defines a struct named `Hashmap` with a single field `hashmap` which is a map with keys of type `string` and values of type `int`. This map will store character counts.

3. **Insert Method**:
   - `func (this *Hashmap) Insert(x string)`: Defines a method named `Insert` for the `Hashmap` struct. It takes a `string` parameter `x`.
   - Inside the method:
     - `if _, ok := this.hashmap[x]; ok { this.hashmap[x] += 1 } else { this.hashmap[x] = 1 }`: This code checks if the character `x` is already present in the hashmap. If it is, it increments the count by 1. If it is not, it adds the character to the hashmap with a count of 1.

### main.go

This file defines the `permutePalindrome` function and the `main` function to test it.

```go
package main

func permutePalindrome(st string) bool {
    hm := Hashmap{hashmap: make(map[string]int)}

    for _, char := range st {
        hm.Insert(string(char)) // Convert rune to string
    }

    oddCount := 0
    for _, count := range hm.hashmap {
        if count%2 != 0 {
            oddCount++
        }
        if oddCount > 1 {
            return false
        }
    }

    return true
}

func main() {
    testCases := []string{"code", "aab", "carerac", "racecar", "hello"}

    for _, testCase := range testCases {
        println("Can \"" + testCase + "\" form a palindrome permutation? ", permutePalindrome(testCase))
    }
}
```

#### Explanation

1. **Package Declaration**:

   - `package main`: Declares that this file is part of the main package.

2. **permutePalindrome Function**:

   - `func permutePalindrome(st string) bool`: Defines a function named `permutePalindrome` that takes a `string` parameter `st` and returns a `bool`.
   - Inside the function:
     - `hm := Hashmap{hashmap: make(map[string]int)}`: Initializes a `Hashmap` instance with an empty map.
     - `for _, char := range st { hm.Insert(string(char)) }`: Iterates through each character in the input string `st`. Each character is a `rune`, so it is converted to a `string` using `string(char)` before calling the `Insert` method to add it to the hashmap.
     - `oddCount := 0`: Initializes a counter for characters with odd counts.
     - `for _, count := range hm.hashmap { if count%2 != 0 { oddCount++ } if oddCount > 1 { return false } }`: Iterates through the counts of each character in the hashmap. If a count is odd, it increments the `oddCount`. If `oddCount` exceeds 1, it returns `false` (indicating that the string cannot form a palindrome permutation).
     - `return true`: If `oddCount` is 0 or 1, it returns `true` (indicating that the string can form a palindrome permutation).

3. **main Function**:
   - `func main()`: Defines the `main` function which is the entry point of the program.
   - Inside the function:
     - `testCases := []string{"code", "aab", "carerac", "racecar", "hello"}`: Defines a slice of strings to test the `permutePalindrome` function.
     - `for _, testCase := range testCases { println("Can \"" + testCase + "\" form a palindrome permutation? ", permutePalindrome(testCase)) }`: Iterates through each test case, calls `permutePalindrome` with the test case string, and prints the result.

### How the Code Works Together

- The `populating_hashmap.go` file defines the `Hashmap` struct and its `Insert` method to keep track of character counts.
- The `main.go` file defines the `permutePalindrome` function to check if a string can be permuted to form a palindrome by using the `Hashmap` to count characters and determine if at most one character has an odd count.
- The `main` function in `main.go` tests the `permutePalindrome` function with various test cases and prints the results.


To determine if a given string is a permutation of a palindrome, we need to check if the string can be rearranged to form a palindrome. A palindrome reads the same forwards and backwards. For a string to be a permutation of a palindrome, it must satisfy specific character frequency criteria:

1. For strings of even length, all characters must occur an even number of times.
2. For strings of odd length, exactly one character must occur an odd number of times, while all other characters must occur an even number of times.

Here's how we can approach this problem using a hash table (or a dictionary in Python) to track character frequencies:

### Steps:

1. **Create a frequency dictionary**: Iterate through the string and count the frequency of each character.
2. **Count odd frequencies**: Iterate through the frequency dictionary and count how many characters have an odd frequency.
3. **Check the condition**: If the count of characters with an odd frequency is greater than one, the string cannot be a permutation of a palindrome.

### Implementation in Python:

```python
def can_permute_palindrome(s: str) -> bool:
    # Create a dictionary to count character frequencies
    char_count = {}
    
    # Count the frequency of each character
    for char in s:
        if char != ' ':  # Ignore spaces
            char = char.lower()  # Ignore case
            char_count[char] = char_count.get(char, 0) + 1
    
    # Count how many characters have an odd frequency
    odd_count = 0
    for count in char_count.values():
        if count % 2 != 0:
            odd_count += 1
    
    # For the string to be a permutation of a palindrome
    # there must be at most one character with an odd frequency
    return odd_count <= 1

# Example usage
example_string = "Tact Coa"  # "Taco cat", "atco cta", etc.
print(can_permute_palindrome(example_string))  # Output: True
```

### Explanation:

- **Step 1**: We create a dictionary `char_count` to store the frequency of each character.
- **Step 2**: We iterate through the string, ignoring spaces and considering characters in a case-insensitive manner. We update the frequency of each character in the dictionary.
- **Step 3**: We count how many characters have an odd frequency by iterating through the values in the dictionary.
- **Step 4**: We check if the count of odd frequencies is less than or equal to one. If true, the string can be permuted to form a palindrome.

### Edge Cases:

- **Empty String**: An empty string is trivially a permutation of a palindrome.
- **Single Character**: A single character is a palindrome by itself.
- **Spaces and Case Sensitivity**: Ignore spaces and treat characters case-insensitively.

This approach efficiently checks the conditions for a string to be a permutation of a palindrome by leveraging a hash table to track character frequencies.

The Go implementation you provided looks good and adheres to the logic required to determine if a string can be permuted to form a palindrome. Here’s a brief overview of the steps:

1. **Hashmap Struct**: Defines a struct `Hashmap` with a method to insert and count characters.
2. **permutePalindrome Function**: Uses the `Hashmap` to count character frequencies and checks for the palindrome permutation condition.
3. **Main Function**: Tests the function with various test cases.

Here's a slight enhancement to improve clarity and ensure best practices in Go:

### Enhanced Go Implementation:

```go
package main

import (
	"fmt"
)

// Hashmap struct to track character counts
type Hashmap struct {
	hashmap map[rune]int
}

// Insert method to add characters to the hashmap
func (hm *Hashmap) Insert(x rune) {
	if _, ok := hm.hashmap[x]; ok {
		hm.hashmap[x]++
	} else {
		hm.hashmap[x] = 1
	}
}

// Function to check if a string can be permuted to form a palindrome
func permutePalindrome(st string) bool {
	hm := Hashmap{hashmap: make(map[rune]int)}

	// Insert characters into the hashmap
	for _, char := range st {
		hm.Insert(char)
	}

	oddCount := 0
	// Count characters with odd occurrences
	for _, count := range hm.hashmap {
		if count%2 != 0 {
			oddCount++
		}
		if oddCount > 1 {
			return false
		}
	}

	return true
}

func main() {
	testCases := []string{
		"code", "aab", "carerac", "racecar", "hello",
		"baefeab", "abc", "xzz", "jjadd", "kllk",
	}

	for _, testCase := range testCases {
		fmt.Printf("Can \"%s\" form a palindrome permutation? %v\n", testCase, permutePalindrome(testCase))
	}
}
```

### Explanation:

1. **Hashmap Struct**:
   - Changed the map key type from `string` to `rune` to handle characters directly, which is more idiomatic in Go for handling individual characters.
   - Simplified the `Insert` method to work with `rune` instead of converting runes to strings.

2. **permutePalindrome Function**:
   - Initializes a `Hashmap` instance to count character frequencies.
   - Iterates through the string and inserts characters into the hashmap.
   - Counts characters with odd frequencies and checks if there is more than one such character.

3. **Main Function**:
   - Provides a set of test cases and prints the results for each.

### Additional Notes:

- **Unicode Handling**: Using `rune` ensures that the function handles Unicode characters correctly.
- **Efficiency**: The function operates in O(n) time complexity, where n is the length of the string, ensuring it runs efficiently even for longer strings.
- **Readability**: The use of `fmt.Printf` provides clear and formatted output.

This implementation maintains the core logic while improving the handling of character data and ensuring that the code adheres to Go best practices.