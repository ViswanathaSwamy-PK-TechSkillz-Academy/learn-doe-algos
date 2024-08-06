namespace MergeIntervals.Algo;

class IntervalMergerTests
{
    static void Main(string[] args)
    {
        var testCases = new List<(List<int[]>, List<int[]>)>
            {
                (new List<int[]> { new int[] { 1, 5 }, new int[] { 3, 7 }, new int[] { 4, 6 } }, new List<int[]> { new int[] { 1, 7 } }),
                (new List<int[]> { new int[] { 1, 5 }, new int[] { 4, 6 }, new int[] { 6, 8 }, new int[] { 11, 15 } }, new List<int[]> { new int[] { 1, 8 }, new int[] { 11, 15 } }),
                (new List<int[]> { new int[] { 3, 7 }, new int[] { 6, 8 }, new int[] { 10, 12 }, new int[] { 11, 15 } }, new List<int[]> { new int[] { 3, 8 }, new int[] { 10, 15 } }),
                (new List<int[]> { new int[] { 1, 5 } }, new List<int[]> { new int[] { 1, 5 } }),
                (new List<int[]> { new int[] { 1, 9 }, new int[] { 3, 8 }, new int[] { 4, 4 } }, new List<int[]> { new int[] { 1, 9 } }),
                (new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 8, 8 } }, new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 8, 8 } }),
                (new List<int[]> { new int[] { 1, 5 }, new int[] { 1, 3 } }, new List<int[]> { new int[] { 1, 5 } }),
                (new List<int[]> { new int[] { 1, 5 }, new int[] { 6, 9 } }, new List<int[]> { new int[] { 1, 5 }, new int[] { 6, 9 } }),
                (new List<int[]> { new int[] { 0, 0 }, new int[] { 1, 18 }, new int[] { 1, 3 } }, new List<int[]> { new int[] { 0, 0 }, new int[] { 1, 18 } })
            };

        foreach (var (intervals, expected) in testCases)
        {
            var result = IntervalMerger.MergeIntervals(intervals);
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
        if (a.Count != b.Count) return false;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i][0] != b[i][0] || a[i][1] != b[i][1]) return false;
        }
        return true;
    }


}