// File: kth_largest.go

package largestnumber

import (
	"container/heap"
)

// KthLargest maintains the Kth largest element in a stream
type KthLargest struct {
	topKHeap *MinHeap
	k        int
}

// NewKthLargest creates a new KthLargest instance
func NewKthLargest(k int, nums []int) *KthLargest {
	kl := &KthLargest{
		topKHeap: NewMinHeap(),
		k:        k,
	}
	for _, num := range nums {
		kl.Add(num)
	}
	return kl
}

// Add inserts a new value and returns the Kth largest element
func (kl *KthLargest) Add(val int) int {
	if kl.topKHeap.Len() < kl.k {
		heap.Push(kl.topKHeap, val)
	} else if val > (*kl.topKHeap)[0] {
		heap.Pop(kl.topKHeap)
		heap.Push(kl.topKHeap, val)
	}

	return (*kl.topKHeap)[0]
}
