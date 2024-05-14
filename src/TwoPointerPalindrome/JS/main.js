function isPalindrome(s) {
    let left = 0,
        right = s.length - 1;

    while (left < right) {
        console.log(`Current elements being pointed to by the left index: '${s[left]}' and right index: '${s[right]}'`);

        if (s[left] != s[right]) { // If the elements at index l and index r are not equal,
            console.log("The elements aren't the same, hence we return false");
            return false;
        }

        console.log("They are the same, thus we move the two pointers toward the middle to continue the \tverification process.");

        left++; // Heading towards the right
        right--; // Heading towards the left
        // console.log(`The new element at the left pointer is ${s[left]}, and right pointer is ${s[right]}`);
    }

    // We reached the middle of the string without finding a mismatch, so it is a palindrome.
    return true;
}

function main() {
    let testCases = ["RACEACAR", "A", "ABCDEFGFEDCBA", "ABC", "ABCBA", "ABBA", "RACEACAR"], i = 1;

    testCases.map((s, index) => {
        console.log("Test Case #", i);
        console.log("-".repeat(100));
        console.log(`The input string is '${s}' and the length of the string is ${s.length}.`);
        console.log("\nIs it a palindrome?.....", isPalindrome(s));
        console.log("-".repeat(100));
        i++;
    });
}

main();