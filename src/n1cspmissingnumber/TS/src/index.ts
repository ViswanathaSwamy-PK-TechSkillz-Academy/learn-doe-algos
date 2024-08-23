// File: index.ts

import { findMissingNumber } from './missingnumber/findMissingNumber';

const inputNumbers: number[][] = [
    [4, 0, 3, 1],
    [8, 3, 5, 2, 4, 6, 0, 1],
    [1, 2, 3, 4, 6, 7, 8, 9, 10, 5],
    [0],
    [1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23]
];

inputNumbers.forEach((nums, i) => {
    console.log(`${i + 1}. nums: [${nums.join(', ')}]`);
    console.log(`   Missing number: ${findMissingNumber(nums)}`);
    console.log('-'.repeat(100));
});
