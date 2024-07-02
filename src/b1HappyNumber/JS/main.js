const { isHappyNumber } = require("./is_happy_number.js");

// Driver code
function main() {
    inputs = [1, 5, 19, 25, 7];
    for (var i = 0; i < inputs.length; i++) {
        console.log(i + 1 + ".\tInput Number:", inputs[i])

        var result = (isHappyNumber(inputs[i])) ? "True" : "False"

        console.log("\n\tIs it a happy number?", result)
        console.log("-".repeat(100));
    }
}

main();