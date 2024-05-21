static bool IsPalindrome(string s)
{
    int left = 0;
    int right = s.Length - 1;

    while (left < right)
    {
        WriteLine($"Current elements left index: '{s[left]}' and right index: '{s[right]}'");

        if (s[left] != s[right])
        {
            WriteLine("The elements aren't the same, hence we return false");
            return false;
        }

        left++; // Heading towards the right
        right--; // Heading towards the left
    }

    return true;
}

string[] testCases = ["RACEACAR", "A", "ABCDEFGFEDCBA", "ABC", "ABCBA", "ABBA", "RACEACAR"];
int i = 1;

foreach (string s in testCases)
{
    WriteLine($"Test Case #{i}");
    WriteLine(new string('-', 100));
    WriteLine($"The input string is '{s}' and the length of the string is {s.Length}.");
    WriteLine("\nIs it a palindrome?..... " + IsPalindrome(s));
    WriteLine(new string('-', 100));
    i++;
}

