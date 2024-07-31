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
