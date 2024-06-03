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
