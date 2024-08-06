using MergeIntervals.Algo;

var inputList = new List<List<int[]>>
            {
                new List<int[]> { new int[] { 1, 5 }, new int[] { 3, 7 }, new int[] { 4, 6 } },
                new List<int[]> { new int[] { 1, 5 }, new int[] { 4, 6 }, new int[] { 6, 8 }, new int[] { 11, 15 } },
                new List<int[]> { new int[] { 3, 7 }, new int[] { 6, 8 }, new int[] { 10, 12 }, new int[] { 11, 15 } },
                new List<int[]> { new int[] { 1, 5 } },
                new List<int[]> { new int[] { 1, 9 }, new int[] { 3, 8 }, new int[] { 4, 4 } },
                new List<int[]> { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 8, 8 } },
                new List<int[]> { new int[] { 1, 5 }, new int[] { 1, 3 } },
                new List<int[]> { new int[] { 1, 5 }, new int[] { 6, 9 } },
                new List<int[]> { new int[] { 0, 0 }, new int[] { 1, 18 }, new int[] { 1, 3 } }
            };

foreach (var intervals in inputList)
{
    Console.WriteLine($"Intervals to merge: {string.Join(", ", intervals.Select(i => $"[{i[0]}, {i[1]}]"))}");
    var result = IntervalMerger.MergeIntervals(intervals);
    Console.WriteLine($"Merged intervals: {string.Join(", ", result.Select(i => $"[{i[0]}, {i[1]}]"))}");
    Console.WriteLine(new string('-', 100));
}