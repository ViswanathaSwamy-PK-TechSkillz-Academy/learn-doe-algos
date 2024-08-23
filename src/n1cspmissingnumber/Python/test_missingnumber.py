# File: test_missingnumber.py

import unittest
from missingnumber import find_missing_number


class TestFindMissingNumber(unittest.TestCase):
    def test_find_missing_number(self):
        test_cases = [
            ([4, 0, 3, 1], 2),
            ([8, 3, 5, 2, 4, 6, 0, 1], 7),
            ([1, 2, 3, 4, 6, 7, 8, 9, 10, 5], 0),
            ([0], 1),
            ([1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12,
             13, 14, 15, 16, 17, 18, 19, 20, 21, 23], 22)
        ]

        for nums, expected in test_cases:
            result = find_missing_number(nums)
            self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()
