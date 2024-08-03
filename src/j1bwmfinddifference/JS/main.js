// File: main.js

const extraCharacterIndex = require('./differenceFinder.js');

const string1List = ["wxyz", "cbda", "jlkmn", "courae", "hello"];
const string2List = ["zwxgy", "abc", "klmn", "couearg", "helo"];

for (let i = 0; i < string1List.length; i++) {
  console.log(`${i + 1}.\tString 1 = ${string1List[i]}`);
  console.log(`\tString 2 = ${string2List[i]}`);
  console.log(`\n\tThe extra character is at index: ${extraCharacterIndex(string1List[i], string2List[i])}`);
  console.log('-'.repeat(100));
}