// File: main.ts

import { mergeSorted } from './merge';

const nums1: number[][] = [
    [23, 33, 35, 41, 44, 47, 56, 91, 105, 0, 0, 0, 0, 0, 0],
    [1, 2, 0],
    [1, 1, 1, 0, 0, 0, 0],
    [6, 0, 0],
    [12, 34, 45, 56, 67, 78, 89, 99, 0],
];
const nums2: number[][] = [
    [32, 49, 50, 51, 61, 99],
    [7],
    [1, 2, 3, 4],
    [-99, -45],
    [100],
];
const m: number[] = [9, 2, 3, 1, 8];
const n: number[] = [6, 1, 4, 2, 1];

m.forEach((value, index) => {
    console.log(`${index + 1}.\tnums1: ${nums1[index].join(", ")}, m: ${value}`);
    console.log(`\tnums2: ${nums2[index].join(", ")}, n: ${n[index]}`);
    const result = mergeSorted(nums1[index], value, nums2[index], n[index]);
    console.log(`\tMerged list: ${result.join(", ")}`);
    console.log("-".repeat(100));
});
