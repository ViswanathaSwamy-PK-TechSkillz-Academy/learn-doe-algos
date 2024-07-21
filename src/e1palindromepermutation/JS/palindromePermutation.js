// palindromePermutation.js

function canPermutePalindrome(s) {
    const charCount = new Map();

    for (const char of s) {
        charCount.set(char, (charCount.get(char) || 0) + 1);
    }

    let oddCount = 0;
    for (const count of charCount.values()) {
        if (count % 2 !== 0) {
            oddCount++;
        }

        if (oddCount > 1) {
            return false;
        }
    }

    return true;
}

module.exports = canPermutePalindrome;
