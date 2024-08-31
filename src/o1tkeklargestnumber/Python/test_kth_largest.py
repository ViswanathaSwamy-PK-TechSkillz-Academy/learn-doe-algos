# File: test_kth_largest.py

import unittest
from kth_largest import KthLargest


class TestKthLargest(unittest.TestCase):
    def test_kth_largest(self):
        test_cases = [
            {
                "k": 3,
                "nums": [3, 6, 9, 10],
                "adds": [4, 7, 10, 8, 15],
                "expected": [6, 7, 9, 9, 10],
            }
        ]

        for tc in test_cases:
            kth_largest = KthLargest(tc["k"], tc["nums"])
            for i, val in enumerate(tc["adds"]):
                result = kth_largest.add(val)
                self.assertEqual(result, tc["expected"][i])


if __name__ == "__main__":
    unittest.main()
