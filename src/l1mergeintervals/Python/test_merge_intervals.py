import unittest
from merge_intervals import merge_intervals


class TestMergeIntervals(unittest.TestCase):
    def test_merge_intervals(self):
        test_cases = [
            ([[1, 5], [3, 7], [4, 6]], [[1, 7]]),
            ([[1, 5], [4, 6], [6, 8], [11, 15]], [[1, 8], [11, 15]]),
            ([[3, 7], [6, 8], [10, 12], [11, 15]], [[3, 8], [10, 15]]),
            ([[1, 5]], [[1, 5]]),
            ([[1, 9], [3, 8], [4, 4]], [[1, 9]]),
            ([[1, 2], [3, 4], [8, 8]], [[1, 2], [3, 4], [8, 8]]),
            ([[1, 5], [1, 3]], [[1, 5]]),
            ([[1, 5], [6, 9]], [[1, 5], [6, 9]]),
            ([[0, 0], [1, 18], [1, 3]], [[0, 0], [1, 18]])
        ]

        for intervals, expected in test_cases:
            with self.subTest(intervals=intervals, expected=expected):
                self.assertEqual(merge_intervals(intervals), expected)


if __name__ == '__main__':
    unittest.main()
