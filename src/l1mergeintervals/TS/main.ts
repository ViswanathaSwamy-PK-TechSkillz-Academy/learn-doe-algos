import { mergeIntervals } from './mergeIntervals';

const inputList: number[][][] = [
    [[1, 5], [3, 7], [4, 6]],
    [[1, 5], [4, 6], [6, 8], [11, 15]],
    [[3, 7], [6, 8], [10, 12], [11, 15]],
    [[1, 5]],
    [[1, 9], [3, 8], [4, 4]],
    [[1, 2], [3, 4], [8, 8]],
    [[1, 5], [1, 3]],
    [[1, 5], [6, 9]],
    [[0, 0], [1, 18], [1, 3]],
];

inputList.forEach((intervals, index) => {
    console.log(`${index + 1}. Intervals to merge: ${JSON.stringify(intervals)}`);
    const result = mergeIntervals(intervals);
    console.log(`Merged intervals: ${JSON.stringify(result)}`);
    console.log('-'.repeat(100));
});
