// File: main.go

package main

import (
	"fmt"
	"o1tkeklargestnumber/kthlargest"
	"strings"
)

func main() {
	nums := []int{3, 6, 9, 10}
	fmt.Print("Initial stream: ")
	printArray(nums)
	fmt.Println("\nk:", 3)
	kLargest := kthlargest.NewKthLargest(3, nums)
	val := []int{4, 7, 10, 8, 15}
	for _, v := range val {
		fmt.Println("\tAdding a new number", v, "to the stream")
		nums = append(nums, v)
		fmt.Print("\tNumber stream: ")
		printArray(nums)
		fmt.Println("\n\tKth largest element in the stream:", kLargest.Add(v))
		fmt.Println(strings.Repeat("-", 100))
	}
}

func printArray(arr []int) {
	fmt.Printf("[%v]", strings.Trim(strings.Join(strings.Fields(fmt.Sprint(arr)), ", "), "[]"))
}
