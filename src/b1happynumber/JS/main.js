// main.js

const { isHappyNumber } = require('./happyNumberHelper');

function main() {
    const inputs = [1, 5, 19, 25, 7];
    inputs.forEach((input, i) => {
        console.log(`${i + 1}.\tInput Number: ${input}`);

        const result = isHappyNumber(input) ? "True" : "False";

        console.log(`\n\tIs it a happy number? ${result}`);
        console.log("-" + "-".repeat(99));
    });
}

main();
