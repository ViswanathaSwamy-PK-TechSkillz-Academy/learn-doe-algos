// File: kth_largest_test.go

package largestnumber

import (
	"testing"
)

func TestKthLargest(t *testing.T) {
	testCases := []struct {
		k        int
		nums     []int
		adds     []int
		expected []int
	}{
		{
			k:        3,
			nums:     []int{3, 6, 9, 10},
			adds:     []int{4, 7, 10, 8, 15},
			expected: []int{9, 9, 10, 10, 15},
		},
		// Add more test cases as needed
	}

	for _, tc := range testCases {
		kLargest := NewKthLargest(tc.k, tc.nums)
		for i, val := range tc.adds {
			result := kLargest.Add(val)
			if result != tc.expected[i] {
				t.Errorf("For adding %d, expected %d but got %d", val, tc.expected[i], result)
			}
		}
	}
}
