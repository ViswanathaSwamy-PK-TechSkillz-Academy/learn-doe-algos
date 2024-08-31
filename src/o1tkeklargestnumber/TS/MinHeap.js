"use strict";
// File: MinHeap.ts
Object.defineProperty(exports, "__esModule", { value: true });
exports.MinHeap = void 0;
class MinHeap {
    constructor() {
        this.heap = [];
    }
    length() {
        return this.heap.length;
    }
    less(i, j) {
        return this.heap[i] < this.heap[j];
    }
    swap(i, j) {
        [this.heap[i], this.heap[j]] = [this.heap[j], this.heap[i]];
    }
    push(x) {
        this.heap.push(x);
        this.heapifyUp(this.heap.length - 1);
    }
    pop() {
        if (this.heap.length === 0)
            return undefined;
        const top = this.heap[0];
        const bottom = this.heap.pop();
        if (this.heap.length > 0 && bottom !== undefined) {
            this.heap[0] = bottom;
            this.heapifyDown(0);
        }
        return top;
    }
    heapifyUp(index) {
        while (index > 0) {
            const parentIndex = Math.floor((index - 1) / 2);
            if (this.less(index, parentIndex)) {
                this.swap(index, parentIndex);
                index = parentIndex;
            }
            else {
                break;
            }
        }
    }
    heapifyDown(index) {
        while (index < this.heap.length) {
            const leftChild = 2 * index + 1;
            const rightChild = 2 * index + 2;
            let smallest = index;
            if (leftChild < this.heap.length && this.less(leftChild, smallest)) {
                smallest = leftChild;
            }
            if (rightChild < this.heap.length && this.less(rightChild, smallest)) {
                smallest = rightChild;
            }
            if (smallest !== index) {
                this.swap(index, smallest);
                index = smallest;
            }
            else {
                break;
            }
        }
    }
    peek() {
        return this.heap.length > 0 ? this.heap[0] : undefined;
    }
}
exports.MinHeap = MinHeap;
