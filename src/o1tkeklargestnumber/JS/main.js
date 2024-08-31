// File: main.js

const KthLargest = require('./KthLargest');

function printArray(arr) {
    console.log(`[${arr.join(', ')}]`);
}

function main() {
    const nums = [3, 6, 9, 10];
    console.log("Initial stream: ", end = "");
    printArray(nums);
    console.log("\nk:", 3);
    const kLargest = new KthLargest(3, nums);
    const valuesToAdd = [4, 7, 10, 8, 15];

    valuesToAdd.forEach(val => {
        console.log(`\tAdding a new number ${val} to the stream`);
        nums.push(val);
        console.log("\tNumber stream: ", end = "");
        printArray(nums);
        console.log(`\n\tKth largest element in the stream: ${kLargest.add(val)}`);
        console.log("-".repeat(100));
    });
}

main();
