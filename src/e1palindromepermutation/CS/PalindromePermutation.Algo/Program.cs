// File: Program.cs

using PalindromePermutation.Algo;

string[] testCases = ["code", "aab", "carerac", "racecar", "hello", "baefeab", "abc", "xzz", "jjadd", "kllk"];

foreach (var testCase in testCases)
{
    WriteLine($"Can \"{testCase}\" form a palindrome permutation? {PalinPermutation.CanPermutePalindrome(testCase)}");
}