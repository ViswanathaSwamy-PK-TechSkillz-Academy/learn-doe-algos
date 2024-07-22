const binarySearch = require('./binary_search');

const numsLists = [
    [],
    [0, 1],
    [1, 2, 3],
    [-1, 0, 3, 5, 9, 12],
    [-100, -67, -55, -50, -49, -40, -33, -22, -10, -5],
];

const targetList = [12, 1, 3, 9, -22];

for (let i = 0; i < numsLists.length; i++) {
    const nums = numsLists[i];
    const target = targetList[i];
    const index = binarySearch(nums, target);

    console.log(`${i + 1}.\tArray to search: [${nums.join(', ')}]`);
    console.log(`\tTarget: ${target}`);

    if (index !== -1) {
        console.log(`\t${target} exists in the array at index ${index}`);
    } else {
        console.log(`\t${target} does not exist in the array, so the return value is ${index}`);
    }

    console.log('-'.repeat(100));
}
