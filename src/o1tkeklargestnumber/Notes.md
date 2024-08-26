# Top K Element - Kth Largest Number

If you're placing the test file inside the same folder as the `algo` package, you should structure the test file accordingly. The `algo` package will be used within the test file, so the import path should be relative to your module path.

## Algorithm

Here's the updated structure and contents for the files:

### Directory Structure

```powershell
yourmodule/
  ├── algo/
  │   ├── minheap.go
  │   ├── kth_largest.go
  │   └── kth_largest_test.go
  └── main.go
```

### File: `algo/minheap.go`

```go
// File: minheap.go

package algo

import (
	"container/heap"
)

// MinHeap represents a min-heap
type MinHeap []int

// Len returns the length of the MinHeap
func (h MinHeap) Len() int {
	return len(h)
}

// Less compares two elements in the MinHeap
func (h MinHeap) Less(i, j int) bool {
	return h[i] < h[j]
}

// Swap swaps two elements in the MinHeap
func (h MinHeap) Swap(i, j int) {
	h[i], h[j] = h[j], h[i]
}

// Push adds an element to the MinHeap
func (h *MinHeap) Push(x interface{}) {
	*h = append(*h, x.(int))
}

// Pop removes and returns the smallest element from the MinHeap
func (h *MinHeap) Pop() interface{} {
	old := *h
	n := len(old)
	x := old[n-1]
	*h = old[:n-1]
	return x
}
```

### File: `algo/kth_largest.go`

```go
// File: kth_largest.go

package algo

import (
	"container/heap"
)

// KthLargest tracks the Kth largest element in a stream
type KthLargest struct {
	topKHeap *MinHeap
	k        int
}

// NewKthLargest initializes the KthLargest structure
func NewKthLargest(k int, nums []int) *KthLargest {
	kl := &KthLargest{
		topKHeap: &MinHeap{},
		k:        k,
	}
	heap.Init(kl.topKHeap)

	for _, element := range nums {
		kl.Add(element)
	}
	return kl
}

// Add inserts a new element into the heap and returns the Kth largest
func (kl *KthLargest) Add(val int) int {
	if kl.topKHeap.Len() < kl.k {
		heap.Push(kl.topKHeap, val)
	} else if val > (*kl.topKHeap)[0] {
		heap.Pop(kl.topKHeap)
		heap.Push(kl.topKHeap, val)
	}

	return (*kl.topKHeap)[0]
}
```

### File: `algo/kth_largest_test.go`

```go
// File: kth_largest_test.go

package algo

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
```

### File: `main.go`

```go
// File: main.go

package main

import (
	"fmt"
	"strings"
	"yourmodule/algo" // Adjust import path as necessary
)

func main() {
	nums := []int{3, 6, 9, 10}
	temp := []int{3, 6, 9, 10}
	fmt.Print("Initial stream: ")
	printArray(nums)
	fmt.Println("\nk:", 3)
	kLargest := algo.NewKthLargest(3, nums)
	val := []int{4, 7, 10, 8, 15}
	for i := 0; i < len(val); i++ {
		fmt.Println("\tAdding a new number", val[i], "to the stream")
		temp = append(temp, val[i])
		fmt.Print("\tNumber stream: ")
		printArray(temp)
		fmt.Println("\n\tKth largest element in the stream:", kLargest.Add(val[i]))
		fmt.Println(strings.Repeat("-", 100))
	}
}

func printArray(arr []int) {
	fmt.Print("[")
	for i := 0; i < len(arr); i++ {
		fmt.Print(arr[i])
		if i != len(arr)-1 {
			fmt.Print(", ")
		}
	}
	fmt.Print("]")
}
```

### Running Tests

To run tests for the `algo` package, navigate to the `algo` directory in your terminal and use the `go test` command:

```sh
cd path/to/yourmodule/algo
go test
```

This command will discover and run the tests defined in `kth_largest_test.go`.

Make sure to adjust the import path in `main.go` to reflect your actual module name.
