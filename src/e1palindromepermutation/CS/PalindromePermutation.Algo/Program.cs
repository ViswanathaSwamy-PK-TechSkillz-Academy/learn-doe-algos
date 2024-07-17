var testCases = new string[]
            {
                "code", "aab", "carerac", "racecar", "hello",
                "baefeab", "abc", "xzz", "jjadd", "kllk"
            };

foreach (var testCase in testCases)
{
    WriteLine($"Can \"{testCase}\" form a palindrome permutation? {PalindromePermutation.CanPermutePalindrome(testCase)}");
}