def is_palindrome(s):
    left, right = 0, len(s) - 1

    while left < right:
        print(f"Current elements left index: '{
              s[left]}' and right index: '{s[right]}'")

        if s[left] != s[right]:
            print("The elements aren't the same, hence we return False")
            return False

        left += 1       # Heading towards the right
        right -= 1      # Heading towards the left

    return True     # We reached the middle of the string without finding a mismatch, so it is a palindrome.


def main():
    test_cases = ["RACEACAR", "A", "ABCDEFGFEDCBA",
                  "ABC", "ABCBA", "ABBA", "RACEACAR"]
    i = 1

    for s in test_cases:
        print(f"Test Case #{i}")
        print("-" * 100)
        print(f"The input string is '{
              s}' and the length of the string is {len(s)}.")
        print("\nIs it a palindrome?.....", is_palindrome(s))
        print("-" * 100)
        i += 1


main()
