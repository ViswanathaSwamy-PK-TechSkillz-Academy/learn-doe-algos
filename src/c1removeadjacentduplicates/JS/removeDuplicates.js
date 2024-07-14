// removeDuplicates function to remove consecutive duplicates from a string
function removeDuplicates(s) {
    const stack = [];

    for (const char of s) {
        if (stack.length > 0 && stack[stack.length - 1] === char) {
            stack.pop(); // pop the last element
        } else {
            stack.push(char); // push the current character
        }
    }

    return stack.join('');
}

module.exports = removeDuplicates;
