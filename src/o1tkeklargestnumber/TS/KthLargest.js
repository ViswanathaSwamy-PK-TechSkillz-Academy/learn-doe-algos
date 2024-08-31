"use strict";
// File: KthLargest.ts
Object.defineProperty(exports, "__esModule", { value: true });
exports.KthLargest = void 0;
const MinHeap_1 = require("./MinHeap");
class KthLargest {
    constructor(k, nums) {
        this.k = k;
        this.topKHeap = new MinHeap_1.MinHeap();
        nums.forEach(num => this.add(num));
    }
    add(val) {
        if (this.topKHeap.length() < this.k) {
            this.topKHeap.push(val);
        }
        else if (val > (this.topKHeap.peek() || -Infinity)) {
            this.topKHeap.pop();
            this.topKHeap.push(val);
        }
        return this.topKHeap.peek() || -1;
    }
}
exports.KthLargest = KthLargest;
