package main

import (
	"fmt"
	"strings"
)

func main() {
	numsLists := [][]int{
		{3, 7, 1, 2, 8, 4, 5},
		{-1, 2, 1, -4, 5, -3},
		{2, 3, 4, 1, 7, 9},
		{1, -1, 0},
		{2, 4, 2, 7, 6, 3, 1},
	}

	testLists := []int{10, 7, 20, -1, 8}

	for i, numList := range numsLists {
		fmt.Println("-" + strings.Repeat("-", 99))

		fmt.Printf("%d.\tInput array: %v\n", i+1, numList)

		if FindSumOfThree(numList, testLists[i]) {
			fmt.Printf("\tSum for %d exists\n", testLists[i])
		} else {
			fmt.Printf("\tSum for %d does not exist\n", testLists[i])
		}

		fmt.Println("-" + strings.Repeat("-", 99))
	}
}
