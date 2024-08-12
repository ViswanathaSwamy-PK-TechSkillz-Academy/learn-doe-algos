// File: IntervalMergerTests.cs

namespace MergeIntervals.Algo;

class IntervalMergerTests
{
    static void Main(string[] args)
    {
        List<(List<int[]>, List<int[]>)> testCases =
        [
                ([[1, 5], [3, 7], [4, 6]], [[1, 7]]),
                ([[1, 5], [4, 6], [6, 8], [11, 15]], [[1, 8], [11, 15]]),
                ([[3, 7], [6, 8], [10, 12], [11, 15]], [[3, 8], [10, 15]]),
                ([[1, 5]], [[1, 5]]),
                ([[1, 9], [3, 8], [4, 4]], [[1, 9]]),
                ([[1, 2], [3, 4], [8, 8]], [[1, 2], [3, 4], [8, 8]]),
                ([[1, 5], [1, 3]], [[1, 5]]),
                ([[1, 5], [6, 9]], [[1, 5], [6, 9]]),
                ([[0, 0], [1, 18], [1, 3]], [[0, 0], [1, 18]])
            ];

        foreach ((List<int[]> intervals, List<int[]> expected) in testCases)
        {
            List<int[]>? result = IntervalMerger.MergeIntervals(intervals);

            if (!IntervalsEqual(result, expected))
            {
                WriteLine($"Test failed: expected {string.Join(", ", expected.Select(i => $"[{i[0]}, {i[1]}]"))}, but got {string.Join(", ", result.Select(i => $"[{i[0]}, {i[1]}]"))}");
            }
            else
            {
                WriteLine($"Test passed.");
            }
        }
    }

    static bool IntervalsEqual(List<int[]> a, List<int[]> b)
    {
        if (a.Count != b.Count)
        {
            return false;
        }

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i][0] != b[i][0] || a[i][1] != b[i][1]) return false;
        }

        return true;
    }


}