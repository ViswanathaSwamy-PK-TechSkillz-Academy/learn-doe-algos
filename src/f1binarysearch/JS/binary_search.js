function binarySearch(nums, target) {
    let low = 0;
    let high = nums.length - 1;

    while (low <= high) {
        const mid = low + Math.floor((high - low) / 2);
        if (nums[mid] === target) {
            return mid;
        }
        if (target < nums[mid]) {
            high = mid - 1;
        } else {
            low = mid + 1;
        }
    }

    return -1;
}

module.exports = binarySearch;
