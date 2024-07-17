// populating_hashmap.go
package main

// Hashmap struct to track character counts
type Hashmap struct {
	hashmap map[rune]int
}

// Insert method to add characters to the hashmap
func (hm *Hashmap) Insert(x rune) {
	hm.hashmap[x]++
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
