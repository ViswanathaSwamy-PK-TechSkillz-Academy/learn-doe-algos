const { mergeIntervals } = require('./mergeIntervals');

function arraysEqual(a, b) {
    if (a.length !== b.length) return false;
    for (let i = 0; i < a.length; i++) {
        if (a[i][0] !== b[i][0] || a[i][1] !== b[i][1]) return false;
    }
    return true;
}

const tests = [
    { input: [[1, 5], [3, 7], [4, 6]], expected: [[1, 7]] },
    { input: [[1, 5], [4, 6], [6, 8], [11, 15]], expected: [[1, 8], [11, 15]] },
    { input: [[3, 7], [6, 8], [10, 12], [11, 15]], expected: [[3, 8], [10, 15]] },
    { input: [[1, 5]], expected: [[1, 5]] },
    { input: [[1, 9], [3, 8], [4, 4]], expected: [[1, 9]] },
    { input: [[1, 2], [3, 4], [8, 8]], expected: [[1, 2], [3, 4], [8, 8]] },
    { input: [[1, 5], [1, 3]], expected: [[1, 5]] },
    { input: [[1, 5], [6, 9]], expected: [[1, 5], [6, 9]] },
    { input: [[0, 0], [1, 18], [1, 3]], expected: [[0, 0], [1, 18]] },
];

tests.forEach((test, index) => {
    const result = mergeIntervals(test.input);
    if (!arraysEqual(result, test.expected)) {
        console.error(`Test ${index + 1} failed: expected ${JSON.stringify(test.expected)}, but got ${JSON.stringify(result)}`);
    } else {
        console.log(`Test ${index + 1} passed.`);
    }
});
