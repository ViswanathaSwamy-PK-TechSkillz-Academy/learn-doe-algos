// File: minheap.go

package largestnumber

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
