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
	testCases := []string{"code", "aab", "carerac", "racecar", "hello", "baefeab", "abc", "xzz", "jjadd", "kllk"}

	for _, testCase := range testCases {
		println("Can \""+testCase+"\" form a palindrome permutation? ", permutePalindrome(testCase))
	}
}
