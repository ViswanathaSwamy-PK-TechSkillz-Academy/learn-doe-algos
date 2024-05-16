function findSumOfThree(nums, target) {
    // Sort the array in ascending order
    nums.sort((a, b) => a - b);

    for (let i = 0; i < nums.length - 2; i++) {
        let left = i + 1;
        let right = nums.length - 1;

        while (left < right) {
            const sum = nums[i] + nums[left] + nums[right];

            if (sum === target) {
                // Triplet found!
                return true;
            } else if (sum < target) {
                // Move left pointer to increase the sum
                left++;
            } else {
                // Move right pointer to decrease the sum
                right--;
            }
        }
    }

    // No triplet found
    return false;
}

module.exports = { findSumOfThree };

// Example usage
const nums = [1, 4, 2, 7, 5, 3];
const target = 10;

console.log('Sum of Three Numbers: ', findSumOfThree(nums, target)); // Output: true
