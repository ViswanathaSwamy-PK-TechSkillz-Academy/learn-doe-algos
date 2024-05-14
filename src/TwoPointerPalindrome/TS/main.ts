function isPalindrome(s: string): boolean {
    let left = 0;
    let right = s.length - 1;

    while (left < right) {
        console.log(`Current elements left index: '${s[left]}' and right index: '${s[right]}'`);

        if (s[left] !== s[right]) { // If the elements at index l and index r are not equal,
            console.log("The elements aren't the same, hence we return false");
            return false;
        }

        left++; // Heading towards the right
        right--; // Heading towards the left
    }

    // We reached the middle of the string without finding a mismatch, so it is a palindrome.
    return true;
}

function main() {
    const testCases: string[] = ["RACEACAR", "A", "ABCDEFGFEDCBA", "ABC", "ABCBA", "ABBA", "RACEACAR"];
    let i = 1;

    testCases.forEach((s) => {
        console.log(`Test Case #${i}`);
        console.log("-".repeat(100));
        console.log(`The input string is '${s}' and the length of the string is ${s.length}.`);
        console.log("\nIs it a palindrome?.....", isPalindrome(s));
        console.log("-".repeat(100));
        i++;
    });
}

main();
