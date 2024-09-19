// File: main.go

package main

import (
	"fmt"
	"p1thscheduletasks/scheduler"
	"strings"
)

func main() {
	tasksList := [][][]int{
		{
			{1, 1}, {5, 5}, {8, 8}, {4, 4}, {6, 6}, {10, 10}, {7, 7},
		},
		{
			{1, 7}, {1, 7}, {1, 7}, {1, 7}, {1, 7}, {1, 7},
		},
		{
			{1, 7}, {8, 13}, {5, 6}, {10, 14}, {6, 7},
		},
		{
			{1, 3}, {3, 5}, {5, 9}, {9, 12}, {12, 13}, {13, 16}, {16, 17},
		},
		{
			{12, 13}, {13, 15}, {17, 20}, {13, 14}, {19, 21}, {18, 20},
		},
	}

	for i, task := range tasksList {
		fmt.Printf("%d.\tTasks = %s\n", i+1, strings.Replace(fmt.Sprint(task), " ", ", ", -1))
		fmt.Printf("\tOptimal number of machines = %d\n", scheduler.ScheduleTasks(task))
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
