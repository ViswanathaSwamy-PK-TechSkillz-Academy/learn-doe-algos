// File: tasks_test.go

package scheduler

import (
	"testing"
)

func TestScheduleTasks(t *testing.T) {
	testCases := []struct {
		tasks         [][]int
		expectedCount int
	}{
		{
			tasks: [][]int{
				{1, 1}, {5, 5}, {8, 8}, {4, 4}, {6, 6}, {10, 10}, {7, 7},
			},
			expectedCount: 1,
		},
		{
			tasks: [][]int{
				{1, 7}, {1, 7}, {1, 7}, {1, 7}, {1, 7}, {1, 7},
			},
			expectedCount: 6,
		},
		{
			tasks: [][]int{
				{1, 7}, {8, 13}, {5, 6}, {10, 14}, {6, 7},
			},
			expectedCount: 2,
		},
		{
			tasks: [][]int{
				{1, 3}, {3, 5}, {5, 9}, {9, 12}, {12, 13}, {13, 16}, {16, 17},
			},
			expectedCount: 1,
		},
		{
			tasks: [][]int{
				{12, 13}, {13, 15}, {17, 20}, {13, 14}, {19, 21}, {18, 20},
			},
			expectedCount: 3,
		},
	}

	for i, tc := range testCases {
		result := ScheduleTasks(tc.tasks)
		if result != tc.expectedCount {
			t.Errorf("Test case %d failed: expected %d, got %d", i+1, tc.expectedCount, result)
		}
	}
}
