// File: KthLargest.ts

import { MinHeap } from "./MinHeap";

export class KthLargest {
    private topKHeap: MinHeap;
    private k: number;

    constructor(k: number, nums: number[]) {
        this.k = k;
        this.topKHeap = new MinHeap();
        nums.forEach(num => this.add(num));
    }

    public add(val: number): number {
        if (this.topKHeap.length() < this.k) {
            this.topKHeap.push(val);
        } else if (val > (this.topKHeap.peek() || -Infinity)) {
            this.topKHeap.pop();
            this.topKHeap.push(val);
        }
        return this.topKHeap.peek() || -1;
    }
}
