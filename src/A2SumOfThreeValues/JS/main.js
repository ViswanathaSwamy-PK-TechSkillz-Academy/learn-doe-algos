function findSumOfThree(nums, target) {
    nums.sort((a, b) => a - b);  // Sort the array in ascending order

    for (let i = 0; i < nums.length - 2; i++) {
        let left = i + 1;
        let right = nums.length - 1;

        while (left < right) {
            const sum = nums[i] + nums[left] + nums[right];

            if (sum === target) {
                return true;  // Triplet found!
            } else if (sum < target) {
                left++;  // Move left pointer to increase the sum
            } else {
                right--;  // Move right pointer to decrease the sum
            }
        }
    }

    return false;  // Triplet not found
}

module.exports = { findSumOfThree };

// Example usage
function main() {
    let numsLists = [
        [3, 7, 1, 2, 8, 4, 5],
        [-1, 2, 1, -4, 5, -3],
        [2, 3, 4, 1, 7, 9],
        [1, -1, 0],
        [2, 4, 2, 7, 6, 3, 1],
    ];

    let testLists = [10, 7, 20, -1, 8];

    numsLists.map((numList, i) => {
        console.log(i + 1 + ".\tInput array:", numsLists[i]);

        if (findSumOfThree(numsLists[i], testLists[i]))
            console.log("\tSum for", testLists[i], "exists");
        else console.log("\tSum for", testLists[i], "does not exist");

        console.log("-".repeat(100));
    });
}

main();