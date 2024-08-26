// File: main.go

package main

import (
	"fmt"
	algo "o1tkeklargestnumber/largestnumber"
	"strings"
)

func main() {
	nums := []int{3, 6, 9, 10}
	temp := []int{3, 6, 9, 10}
	fmt.Print("Initial stream: ")
	printArray(nums)
	fmt.Println("\nk:", 3)
	kLargest := algo.NewKthLargest(3, nums)
	val := []int{4, 7, 10, 8, 15}
	for i := 0; i < len(val); i++ {
		fmt.Println("\tAdding a new number", val[i], "to the stream")
		temp = append(temp, val[i])
		fmt.Print("\tNumber stream: ")
		printArray(temp)
		fmt.Println("\n\tKth largest element in the stream:", kLargest.Add(val[i]))
		fmt.Println(strings.Repeat("-", 100))
	}
}

func printArray(arr []int) {
	fmt.Print("[")
	for i := 0; i < len(arr); i++ {
		fmt.Print(arr[i])
		if i != len(arr)-1 {
			fmt.Print(", ")
		}
	}
	fmt.Print("]")
}
