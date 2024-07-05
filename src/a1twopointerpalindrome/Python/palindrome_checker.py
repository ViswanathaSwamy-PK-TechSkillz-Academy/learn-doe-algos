# palindrome_checker.py

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

    # We reached the middle of the string without finding a mismatch, so it is a palindrome.
    return True
