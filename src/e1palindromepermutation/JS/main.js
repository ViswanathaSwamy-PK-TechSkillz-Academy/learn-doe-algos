// main.js

const canPermutePalindrome = require('./palindromePermutation');

const testCases = [
    "code", "aab", "carerac", "racecar", "hello",
    "baefeab", "abc", "xzz", "jjadd", "kllk"
];

testCases.forEach(testCase => {
    console.log(`Can "${testCase}" form a palindrome permutation? ${canPermutePalindrome(testCase)}`);
});
