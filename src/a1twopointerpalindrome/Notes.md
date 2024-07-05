# Palindrome Checking Algorithm using Two Pointers

## Few commands

```powershell
npm install -g typescript ts-node
```

## How to execute

```powershell
dotnet run
go run .
javac Main.java && java Main
node .\main.js
py .\main.py
 ts-node .\main.ts
```

## Explaination of the algorithm

1. **Initialization**:

   - We start by initializing two pointers: `left` and `right`.
   - `left` points to the first character of the input string `s`.
   - `right` points to the last character of the input string `s`.

2. **Comparison Loop**:

   - While `left` is less than `right`, we continue checking pairs of characters.
   - The loop ensures that we compare characters from both ends of the string towards the middle.

3. **Character Comparison**:

   - At each iteration, we compare the characters at indices `left` and `right`.
   - If they are not equal, we know that the string is not a palindrome.
   - In this case, we log a message indicating that the elements are different, and we return `false`.

4. **Pointer Movement**:

   - After comparing the characters, we move `left` one step to the right (towards the end of the string).
   - Similarly, we move `right` one step to the left (towards the beginning of the string).

5. **Loop Continuation**:

   - We repeat steps 3 and 4 until `left` is no longer less than `right`.
   - If we find any mismatched characters, we exit the loop early.

6. **Palindrome Check Result**:

   - If we reach the middle of the string without finding any mismatches, we know that the string is a palindrome.
   - In this case, we return `true`.

7. **Test Cases**:
   - The `main()` function demonstrates the algorithm by applying it to several test cases.
   - For each test case, it logs the input string, its length, and whether it is a palindrome.

The algorithm efficiently checks whether a given string is a palindrome by comparing characters from both ends. Feel free to ask if you have any more questions! 😊
