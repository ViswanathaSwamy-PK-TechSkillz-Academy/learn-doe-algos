// main.ts

import { canPermutePalindrome } from './palindromePermutation';

const testCases: string[] = [
    "code", "aab", "carerac", "racecar", "hello",
    "baefeab", "abc", "xzz", "jjadd", "kllk"
];

for (const testCase of testCases) {
    console.log(`Can "${testCase}" form a palindrome permutation? ${canPermutePalindrome(testCase)}`);
}
