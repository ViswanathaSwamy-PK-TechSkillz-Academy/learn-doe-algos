// File: KthLargest.js

const MinHeap = require('./MinHeap');

class KthLargest {
    constructor(k, nums) {
        this.k = k;
        this.minHeap = new MinHeap();
        nums.forEach(num => this.add(num));
    }

    add(val) {
        if (this.minHeap.size() < this.k) {
            this.minHeap.push(val);
        } else if (val > this.minHeap.top()) {
            this.minHeap.pop();
            this.minHeap.push(val);
        }
        return this.minHeap.top();
    }
}

module.exports = KthLargest;
