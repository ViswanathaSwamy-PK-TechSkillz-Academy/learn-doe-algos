# File: kth_largest.py

from minheap import MinHeap


class KthLargest:
    def __init__(self, k, nums):
        self.k = k
        self.min_heap = MinHeap()
        for num in nums:
            self.add(num)

    def add(self, val):
        if self.min_heap.size() < self.k:
            self.min_heap.push(val)
        elif val > self.min_heap.top():
            self.min_heap.pop()
            self.min_heap.push(val)
        return self.min_heap.top()
