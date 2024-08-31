# File: minheap.py

import heapq


class MinHeap:
    def __init__(self):
        self.heap = []

    def push(self, val):
        heapq.heappush(self.heap, val)

    def pop(self):
        return heapq.heappop(self.heap)

    def top(self):
        return self.heap[0] if self.heap else None

    def size(self):
        return len(self.heap)
