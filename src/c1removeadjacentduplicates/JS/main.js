const removeDuplicates = require('./removeDuplicates');

const inputs = [
    "g",
    "ggaabcdeb",
    "abbddaccaaabcd",
    "aannkwwwkkkwna",
    "abbabccblkklu"
];

inputs.forEach((input, i) => {
    console.log(`${i + 1}.\tRemove duplicates from string: "${input}"`);
    const resultingString = removeDuplicates(input);
    console.log(`\tString after removing duplicates: "${resultingString}"`);
    console.log('-'.repeat(100));
});
