package intervals

import (
	"fmt"
	"os"
	"strings"
	"text/tabwriter"
)

// MergeIntervals merges overlapping intervals
func MergeIntervals(intervals [][]int) [][]int {
	if len(intervals) == 0 {
		return nil
	}

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
