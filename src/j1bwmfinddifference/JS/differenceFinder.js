// File: differenceFinder.js

const extraCharacterIndex = (str1, str2) => {
    let result = 0;

    for (let i = 0; i < str1.length; i++) {
        result ^= str1.charCodeAt(i);
    }

    for (let i = 0; i < str2.length; i++) {
        result ^= str2.charCodeAt(i);
    }

    return str1.length > str2.length ? str1.indexOf(String.fromCharCode(result)) : str2.indexOf(String.fromCharCode(result));
};

module.exports = extraCharacterIndex;