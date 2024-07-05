// palindromeChecker.ts

export function isPalindromeTS(s: string): boolean {
    let left = 0;
    let right = s.length - 1;

    while (left < right) {
        console.log(`Current elements left index: '${s[left]}' and right index: '${s[right]}'`);

        if (s[left] !== s[right]) { // If the elements at index l and index r are not equal,
            console.log("The elements aren't the same, hence we return false");
            return false;
        }

        left++;         // Heading towards the right
        right--;        // Heading towards the left
    }

    return true;        // We reached the middle of the string without finding a mismatch, so it is a palindrome.
}
