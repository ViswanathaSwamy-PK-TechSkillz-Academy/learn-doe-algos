// File: Program.cs

using CSPMissingNumber.Alog;

var inputNumbers = new[]
        {
            new[] {4, 0, 3, 1},
            [8, 3, 5, 2, 4, 6, 0, 1],
            [1, 2, 3, 4, 6, 7, 8, 9, 10, 5],
            [0],
            [1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23]
        };

for (int i = 0; i < inputNumbers.Length; i++)
{
    var numbers = inputNumbers[i];

    WriteLine($"{i + 1}.\tNumbers : {string.Join(", ", numbers)}");
    WriteLine($"\n\tMissing number: {MissingNumberFinder.FindMissingNumber(numbers)}");
    WriteLine(new string('-', 100));
}