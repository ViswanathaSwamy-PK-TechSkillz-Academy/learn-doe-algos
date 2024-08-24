// File: kth_largest.go

package largestnumber

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
