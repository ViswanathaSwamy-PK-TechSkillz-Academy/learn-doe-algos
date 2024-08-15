package main

import (
	"fmt"
	"n1cspmissingnumber/missingnumber"
	"strings"
)

func main() {
	inputNumbers := [][]int{
		{4, 0, 3, 1},
		{8, 3, 5, 2, 4, 6, 0, 1},
		{1, 2, 3, 4, 6, 7, 8, 9, 10, 5},
		{0},
		{1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23},
	}

	for i, x := range inputNumbers {
		fmt.Printf("%d.\tnums: %s\n", i+1, strings.Replace(fmt.Sprint(x), " ", ", ", -1))
		fmt.Printf("\n\tMissing number: %d\n", missingnumber.FindMissingNumber(x))
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
