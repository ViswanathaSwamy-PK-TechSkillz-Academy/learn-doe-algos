package main

// removeDuplicates function to remove consecutive duplicates from a string
func removeDuplicates(s string) string {
	stack := []rune{}

	for _, char := range s {
		if len(stack) > 0 && stack[len(stack)-1] == char {
			stack = stack[:len(stack)-1] // pop the last element
		} else {
			stack = append(stack, char) // push the current character
		}
	}

	return string(stack)
}
