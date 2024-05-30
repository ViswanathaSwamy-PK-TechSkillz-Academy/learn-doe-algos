const sumOfSquaredDigits = require("./sum_of_squared_digits.js");
      
function isHappyNumber(n) {
    let slow = n;
    let fast = sumOfSquaredDigits(n);

    while (fast !== 1 && slow !== fast) {
        slow = sumOfSquaredDigits(slow);
        fast = sumOfSquaredDigits(sumOfSquaredDigits(fast));
    }

    return fast === 1;
}

module.exports = { isHappyNumber };
