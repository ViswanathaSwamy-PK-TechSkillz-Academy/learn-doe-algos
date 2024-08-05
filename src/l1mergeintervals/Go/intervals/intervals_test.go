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
