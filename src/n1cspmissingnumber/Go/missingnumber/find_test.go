// File: find_test.go

package missingnumber

import "testing"

func TestFindMissingNumber(t *testing.T) {
	testCases := []struct {
		nums     []int
		expected int
	}{
		{[]int{4, 0, 3, 1}, 2},
		{[]int{8, 3, 5, 2, 4, 6, 0, 1}, 7},
		{[]int{1, 2, 3, 4, 6, 7, 8, 9, 10, 5}, 0},
		{[]int{0}, 1},
		{[]int{1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23}, 22},
	}

	for _, tc := range testCases {
		result := FindMissingNumber(tc.nums)
		if result != tc.expected {
			t.Errorf("For input %v, expected %d but got %d", tc.nums, tc.expected, result)
		}
	}
}
