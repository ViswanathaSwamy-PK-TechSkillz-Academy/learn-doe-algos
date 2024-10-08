// File: KthLargest.test.ts

import { KthLargest } from "./KthLargest";

describe('KthLargest', () => {
    test('should return the Kth largest element in the stream', () => {
        const kLargest = new KthLargest(3, [3, 6, 9, 10]);

        expect(kLargest.add(4)).toBe(6);
        expect(kLargest.add(7)).toBe(7);
        expect(kLargest.add(10)).toBe(9);
        expect(kLargest.add(8)).toBe(9);
        expect(kLargest.add(15)).toBe(10);
    });
});
