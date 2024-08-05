package main

import (
	"fmt"
	"l1mergeintervals/intervals"
	"strings"
)

func main() {
	inputList := [][][]int{
		{{1, 5}, {3, 7}, {4, 6}},
		{{1, 5}, {4, 6}, {6, 8}, {11, 15}},
		{{3, 7}, {6, 8}, {10, 12}, {11, 15}},
		{{1, 5}},
		{{1, 9}, {3, 8}, {4, 4}},
		{{1, 2}, {3, 4}, {8, 8}},
		{{1, 5}, {1, 3}},
		{{1, 5}, {6, 9}},
		{{0, 0}, {1, 18}, {1, 3}},
	}

	for index, value := range inputList {
		fmt.Printf("%d.\tIntervals to merge: %s\n", index+1, strings.Replace(fmt.Sprint(value), " ", ", ", -1))
		result := intervals.MergeIntervals(value)
		fmt.Printf("Merged intervals: %s\n", strings.Replace(fmt.Sprint(result), " ", ", ", -1))
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
