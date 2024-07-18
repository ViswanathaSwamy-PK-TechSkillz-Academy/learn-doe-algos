// palindromePermutation.ts

export function canPermutePalindrome(s: string): boolean {
    const charCount: { [key: string]: number } = {};

    for (const char of s) {
        if (charCount[char] !== undefined) {
            charCount[char]++;
        } else {
            charCount[char] = 1;
        }
    }

    let oddCount = 0;
    for (const count of Object.values(charCount)) {
        if (count % 2 !== 0) {
            oddCount++;
        }

        if (oddCount > 1) {
            return false;
        }
    }

    return true;
}
