// File: heap.go

package scheduler

import "container/heap"

// Heap structure initialization
type Heap [][]int

// newHeap function initializes an instance of the heap
func newHeap() *Heap {
	h := &Heap{}
	heap.Init(h)
	return h
}

// Len function returns the length of the heap
func (h Heap) Len() int {
	return len(h)
}

// Empty function returns true if the heap is empty
func (h Heap) Empty() bool {
	return len(h) == 0
}

// Less function compares two elements of the heap
func (h Heap) Less(i, j int) bool {
	return h[i][0] < h[j][0]
}

// Swap function swaps two elements in the heap
func (h Heap) Swap(i, j int) {
	h[i], h[j] = h[j], h[i]
}

// Top function returns the element at the top of the heap
func (h Heap) Top() interface{} {
	return h[0]
}

// Push function adds an element to the heap
func (h *Heap) Push(x interface{}) {
	*h = append(*h, x.([]int))
}

// Pop function removes the element at the top of the heap
func (h *Heap) Pop() interface{} {
	old := *h
	n := len(old)
	x := old[n-1]
	*h = old[0 : n-1]
	return x
}

// Heapify function adds a list of tasks to the heap
func (h *Heap) Heapify(array [][]int) {
	for _, arr := range array {
		heap.Push(h, arr)
	}
}
