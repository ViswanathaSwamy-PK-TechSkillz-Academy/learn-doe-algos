// File: main.ts

import { KthLargest } from "./KthLargest";

function main() {
    const nums = [3, 6, 9, 10];
    const kLargest = new KthLargest(3, nums);
    const newValues = [4, 7, 10, 8, 15];

    console.log("Initial stream:", nums);
    console.log("k:", 3);

    newValues.forEach(value => {
        console.log(`Adding ${value} to the stream`);
        console.log(`Kth largest element in the stream: ${kLargest.add(value)}`);
        console.log("=".repeat(50));
    });
}

main();
