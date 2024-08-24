// File: minheap.go

package largestnumber

import (
	"container/heap"
)

// MinHeap is a min-heap of integers
type MinHeap []int

// Len returns the number of elements in the heap
func (h MinHeap) Len() int {
	return len(h)
}

// Less returns true if element i is less than element j
func (h MinHeap) Less(i, j int) bool {
	return h[i] < h[j]
}

// Swap exchanges elements i and j
func (h MinHeap) Swap(i, j int) {
	h[i], h[j] = h[j], h[i]
}

// Push adds an element to the heap
func (h *MinHeap) Push(x interface{}) {
	*h = append(*h, x.(int))
}

// Pop removes and returns the minimum element from the heap
func (h *MinHeap) Pop() interface{} {
	old := *h
	n := len(old)
	x := old[n-1]
	*h = old[0 : n-1]

	return x
}

// NewMinHeap initializes and returns a new MinHeap
func NewMinHeap() *MinHeap {
	h := &MinHeap{}
	heap.Init(h)
	return h
}
