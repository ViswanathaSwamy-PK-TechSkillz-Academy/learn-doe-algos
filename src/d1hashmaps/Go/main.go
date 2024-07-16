package main

import (
	"fmt"
	"strings"
)

// Driver code
func main() {
	hashMap := Constructor()
	keys := []int{5, 2069, 2070, 2073, 4138, 2068}
	values := []int{100, 200, 400, 500, 1000, 5000}
	operations := []string{"Get", "Get", "Put", "Get", "Put", "Get", "Get", "Remove", "Get", "Get", "Remove", "Get"}
	operationKeys := [][]int{
		{5}, {2073}, {2073, 250}, {2073},
		{121, 110}, {121}, {2068}, {2069}, {2069},
		{2071}, {2071}, {2071},
	}

	// Initialize the hash map with initial keys and values
	for i := range keys {
		hashMap.Put(keys[i], values[i])
	}

	// Execute the operations
	for i, op := range operations {
		switch op {
		case "Put":
			fmt.Printf("%d.\tPut(%d, %d)\n", i+1, operationKeys[i][0], operationKeys[i][1])
			hashMap.Put(operationKeys[i][0], operationKeys[i][1])
		case "Get":
			fmt.Printf("%d.\tGet(%d)\n", i+1, operationKeys[i][0])
			fmt.Printf("\tValue returned: %d\n", hashMap.Get(operationKeys[i][0]))
		case "Remove":
			fmt.Printf("%d.\tRemove(%d)\n", i+1, operationKeys[i][0])
			hashMap.Remove(operationKeys[i][0])
		}

		// Print the current state of the hash map
		fmt.Printf("\nCurrent Hash Map:\n")
		printHashMap(hashMap)
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}

// printHashMap prints the current state of the hash map.
func printHashMap(hashMap DesignHashMap) {
	for i, bucket := range hashMap.buckets {
		if len(bucket.pairs) > 0 {
			fmt.Printf("Bucket %d: ", i)
			for _, pair := range bucket.pairs {
				fmt.Printf("{key: %d, value: %d} ", pair.key, pair.value)
			}
			fmt.Println()
		}
	}
}
