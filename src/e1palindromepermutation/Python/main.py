# main.py

from palindrome_permutation import can_permute_palindrome

test_cases = [
    "code", "aab", "carerac", "racecar", "hello",
    "baefeab", "abc", "xzz", "jjadd", "kllk"
]

for test_case in test_cases:
    result = can_permute_palindrome(test_case)
    print(f'Can "{test_case}" form a palindrome permutation? {result}')
