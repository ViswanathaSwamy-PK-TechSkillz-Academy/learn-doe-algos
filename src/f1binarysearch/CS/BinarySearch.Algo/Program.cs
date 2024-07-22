using CS.BinarySearch.Algo;

var numsLists = new[]
{
    new int[] {},
    new int[] {0, 1},
    new int[] {1, 2, 3},
    new int[] {-1, 0, 3, 5, 9, 12},
    new int[] {-100, -67, -55, -50, -49, -40, -33, -22, -10, -5},
};

var targetList = new[] { 12, 1, 3, 9, -22 };

for (int i = 0; i < numsLists.Length; i++)
{
    var nums = numsLists[i];
    var target = targetList[i];
    var index = BinarySearch.Search(nums, target);

    WriteLine($"{i + 1}.\tArray to search: [{string.Join(", ", nums)}]");
    WriteLine($"\tTarget: {target}");

    if (index != -1)
    {
        WriteLine($"\t{target} exists in the array at index {index}");
    }
    else
    {
        WriteLine($"\t{target} does not exist in the array, so the return value is {index}");
    }

    WriteLine(new string('-', 100));
}
