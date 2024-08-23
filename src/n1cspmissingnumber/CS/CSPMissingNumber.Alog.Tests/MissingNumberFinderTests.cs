namespace CSPMissingNumber.Alog.Tests;

public class MissingNumberFinderTests
{
    [Fact]
    public void TestFindMissingNumber()
    {
        var testCases = new[]
        {
            (numbers: new[] {4, 0, 3, 1}, expected: 2),
            (numbers: [8, 3, 5, 2, 4, 6, 0, 1], expected: 7),
            (numbers: [1, 2, 3, 4, 6, 7, 8, 9, 10, 5], expected: 0),
            (numbers: [0], expected: 1),
            (numbers: [1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23], expected: 22)
        };

        foreach (var (numbers, expected) in testCases)
        {
            int result = MissingNumberFinder.FindMissingNumber(numbers);
            Assert.Equal(expected, result);
        }
    }
}