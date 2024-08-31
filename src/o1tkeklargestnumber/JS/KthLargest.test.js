// File: KthLargest.test.js

const KthLargest = require('./KthLargest');

test('KthLargest correctly finds the kth largest element', () => {
    const k = 3;
    const nums = [3, 6, 9, 10];
    const kthLargest = new KthLargest(k, nums);

    const adds = [4, 7, 10, 8, 15];
    const expected = [6, 7, 9, 9, 10];

    adds.forEach((val, index) => {
        const result = kthLargest.add(val);
        expect(result).toBe(expected[index]);
    });
});
