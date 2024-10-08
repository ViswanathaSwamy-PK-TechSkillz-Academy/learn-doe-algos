// File: findMissingNumber.ts

export function findMissingNumber(nums: number[]): number {
    const lenNums = nums.length;
    let index = 0;

    // Cyclic Sort
    while (index < lenNums) {
        const value = nums[index];

        if (value < lenNums && value !== nums[value]) {
            [nums[index], nums[value]] = [nums[value], nums[index]];  // Swap
        } else {
            index++;
        }
    }

    // Find the missing number
    for (let i = 0; i < lenNums; i++) {
        if (nums[i] !== i) {
            return i;
        }
    }

    return lenNums;
}
