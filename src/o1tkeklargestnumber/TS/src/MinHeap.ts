// File: MinHeap.ts

export class MinHeap {
    private heap: number[];

    constructor() {
        this.heap = [];
    }

    public length(): number {
        return this.heap.length;
    }

    public less(i: number, j: number): boolean {
        return this.heap[i] < this.heap[j];
    }

    public swap(i: number, j: number): void {
        [this.heap[i], this.heap[j]] = [this.heap[j], this.heap[i]];
    }

    public push(x: number): void {
        this.heap.push(x);
        this.heapifyUp(this.heap.length - 1);
    }

    public pop(): number | undefined {
        if (this.heap.length === 0) return undefined;
        const top = this.heap[0];
        const bottom = this.heap.pop();
        if (this.heap.length > 0 && bottom !== undefined) {
            this.heap[0] = bottom;
            this.heapifyDown(0);
        }
        return top;
    }

    private heapifyUp(index: number): void {
        while (index > 0) {
            const parentIndex = Math.floor((index - 1) / 2);
            if (this.less(index, parentIndex)) {
                this.swap(index, parentIndex);
                index = parentIndex;
            } else {
                break;
            }
        }
    }

    private heapifyDown(index: number): void {
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
            } else {
                break;
            }
        }
    }

    public peek(): number | undefined {
        return this.heap.length > 0 ? this.heap[0] : undefined;
    }
}
