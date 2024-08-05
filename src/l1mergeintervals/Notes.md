# Merge Intervals

## Algo

To enhance and organize the Go code for merging intervals using multiple files, we can separate the logic into distinct files and make some improvements to the code itself. Here’s how the project structure and code can be organized:

### Project Structure:

```
merge_intervals/
├── main.go
├── intervals/
│   ├── intervals.go
│   ├── intervals_test.go
```

### main.go:

```go
package main

import (
	"fmt"
	"strings"
	"merge_intervals/intervals"
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
```

### intervals/intervals.go:

```go
package intervals

import (
	"fmt"
	"os"
	"sort"
	"strings"
	"text/tabwriter"
)

// MergeIntervals merges overlapping intervals
func MergeIntervals(intervals [][]int) [][]int {
	if len(intervals) == 0 {
		return nil
	}

	// Sort intervals by starting time
	sort.Slice(intervals, func(i, j int) bool {
		return intervals[i][0] < intervals[j][0]
	})

	result := make([][]int, 0)
	result = append(result, intervals[0])

	for i := 1; i < len(intervals); i++ {
		lastAddedInterval := result[len(result)-1]
		curStart := intervals[i][0]
		curEnd := intervals[i][1]

		if lastAddedInterval[1] >= curStart {
			lastAddedInterval[1] = max(lastAddedInterval[1], curEnd)
		} else {
			result = append(result, intervals[i])
		}

		printInterval(curStart, curEnd)
	}

	return result
}

func printInterval(curStart, curEnd int) {
	fmt.Printf("\n\t   Current input interval: [%d, %d]\n", curStart, curEnd)

	w := tabwriter.NewWriter(os.Stdout, 10, 0, 0, ' ', tabwriter.Debug)
	fmt.Fprintln(w, "\n\tcurStart\tcurEnd\t")
	fmt.Fprintln(w, "\t", strings.Repeat("-", 10), "\t", strings.Repeat("-", 8), "\t")
	fmt.Fprintln(w, "\t", curStart, "\t", curEnd, "\t")
	w.Flush()
}

func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}
```

### intervals/intervals_test.go:

```go
package intervals

import (
	"testing"
)

func TestMergeIntervals(t *testing.T) {
	tests := []struct {
		input    [][]int
		expected [][]int
	}{
		{[][]int{{1, 5}, {3, 7}, {4, 6}}, [][]int{{1, 7}}},
		{[][]int{{1, 5}, {4, 6}, {6, 8}, {11, 15}}, [][]int{{1, 8}, {11, 15}}},
		{[][]int{{3, 7}, {6, 8}, {10, 12}, {11, 15}}, [][]int{{3, 8}, {10, 15}}},
		{[][]int{{1, 5}}, [][]int{{1, 5}}},
		{[][]int{{1, 9}, {3, 8}, {4, 4}}, [][]int{{1, 9}}},
		{[][]int{{1, 2}, {3, 4}, {8, 8}}, [][]int{{1, 2}, {3, 4}, {8, 8}}},
		{[][]int{{1, 5}, {1, 3}}, [][]int{{1, 5}}},
		{[][]int{{1, 5}, {6, 9}}, [][]int{{1, 5}, {6, 9}}},
		{[][]int{{0, 0}, {1, 18}, {1, 3}}, [][]int{{0, 0}, {1, 18}}},
	}

	for _, test := range tests {
		result := MergeIntervals(test.input)
		if !equal(result, test.expected) {
			t.Errorf("For input %v, expected %v, but got %v", test.input, test.expected, result)
		}
	}
}

func equal(a, b [][]int) bool {
	if len(a) != len(b) {
		return false
	}
	for i := range a {
		if a[i][0] != b[i][0] || a[i][1] != b[i][1] {
			return false
		}
	}
	return true
}
```

### Summary of Improvements:

1. **Separation of Concerns**: The code is organized into separate files for the main logic and the interval merging logic, promoting modularity.
2. **Sorting of Intervals**: Added sorting of intervals by their start time to simplify the merging logic.
3. **Test Coverage**: Added a test file to ensure the merging logic works as expected with various test cases.
4. **Code Cleanup**: Removed unnecessary comments and improved the overall readability of the code.

This structure enhances maintainability and readability while ensuring the code is properly organized and tested.
