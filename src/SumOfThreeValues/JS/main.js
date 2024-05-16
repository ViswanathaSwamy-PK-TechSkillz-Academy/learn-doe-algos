function findSumOfThree(nums, target) {
    nums.sort((a, b) => a - b);     // Sort the array in ascending order

    for (let i = 0; i < nums.length - 2; i++) {
        let left = i + 1;
        let right = nums.length - 1;

        while (left < right) {
            const sum = nums[i] + nums[left] + nums[right];

            if (sum === target) {
                return true;        // Triplet found!
            } else if (sum < target) {
                left++;             // Move left pointer to increase the sum
            } else {
                right--;            // Move right pointer to decrease the sum
            }
        }
    }

    return false;       // Triplet not found
}

module.exports = { findSumOfThree };

// Example usage
const nums = [1, 4, 2, 7, 5, 3];
const target = 10;

console.log('Sum of Three Numbers: ', findSumOfThree(nums, target)); // Output: true
