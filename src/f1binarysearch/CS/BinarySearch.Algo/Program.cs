using BinarySearch.Algo;

int[][] numbersLists = [[], [0, 1], [1, 2, 3], [-1, 0, 3, 5, 9, 12], [-100, -67, -55, -50, -49, -40, -33, -22, -10, -5],];

int[] targetList = [12, 1, 3, 9, -22];

for (int i = 0; i < numbersLists.Length; i++)
{
    int[] numbers = numbersLists[i];
    int target = targetList[i];
    int index = BinarySearchCls.Search(numbers, target);

    WriteLine($"{i + 1}.\tArray to search: [{string.Join(", ", numbers)}]");
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
