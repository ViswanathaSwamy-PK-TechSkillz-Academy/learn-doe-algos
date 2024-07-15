package main

import (
	"fmt"
	"strings"
)

// Driver code
func main() {
	input := Constructor()
	keys := []int{5, 2069, 2070, 2073, 4138, 2068}
	keysList := []int{5, 2069, 2070, 2073, 4138, 2068}
	values := []int{100, 200, 400, 500, 1000, 5000}
	funcs := []string{"Get", "Get", "Put", "Get",
		"Put", "Get", "Get", "Remove",
		"Get", "Get", "Remove", "Get"}
	funcKeys := [][]int{
		{5}, {2073}, {2073, 250}, {2073},
		{121, 110}, {121}, {2068}, {2069}, {2069},
		{2071}, {2071}, {2071},
	}

	for i, _ := range keys {
		input.Put(keys[i], values[i])
	}

	for i, _ := range funcs {
		if funcs[i] == "Put" {
			fmt.Printf("%d.\tput(%d, %d)\n", i+1, funcKeys[i][0], funcKeys[i][1])
			present := false
			for j, _ := range keysList {
				if funcKeys[i][0] == keysList[j] {
					present = true
				}
			}
			if !present {
				keysList = append(keysList, funcKeys[i][0])
			}
			input.Put(funcKeys[i][0], funcKeys[i][1])
		} else if funcs[i] == "Get" {
			fmt.Printf("%d.\tget(%d)\n", i+1, funcKeys[i][0])
			fmt.Printf("\tValue returned: %d\n", input.Get(funcKeys[i][0]))
		} else if funcs[i] == "Remove" {
			fmt.Printf("%d.\tremove(%d)\n", i+1, funcKeys[i][0])
			input.Remove(funcKeys[i][0])
		}

		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
