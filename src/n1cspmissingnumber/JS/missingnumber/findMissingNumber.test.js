const findMissingNumber = require('./findMissingNumber');

test('finds the missing number correctly', () => {
    const testCases = [
        { nums: [4, 0, 3, 1], expected: 2 },
        { nums: [8, 3, 5, 2, 4, 6, 0, 1], expected: 7 },
        { nums: [1, 2, 3, 4, 6, 7, 8, 9, 10, 5], expected: 0 },
        { nums: [0], expected: 1 },
        { nums: [1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23], expected: 22 },
    ];

    testCases.forEach(({ nums, expected }) => {
        expect(findMissingNumber(nums)).toBe(expected);
    });
});
