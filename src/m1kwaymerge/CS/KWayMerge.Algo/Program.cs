using KWayMerge.Algo;

int[][] nums1 = [
    [23, 33, 35, 41, 44, 47, 56, 91, 105, 0, 0, 0, 0, 0, 0],
    [1, 2, 0],
    [1, 1, 1, 0, 0, 0, 0],
    [6, 0, 0],
    [12, 34, 45, 56, 67, 78, 89, 99, 0],
];

int[][] nums2 = [
    [32, 49, 50, 51, 61, 99],
    [7],
    [1, 2, 3, 4],
    [-99, -45],
    [100],
];

int[] m = [9, 2, 3, 1, 8];
int[] n = [6, 1, 4, 2, 1];

for (int index = 0; index < m.Length; index++)
{
    WriteLine($"{index + 1}.\tnums1: {string.Join(", ", nums1[index])}, m: {m[index]}");
    WriteLine($"\tnums2: {string.Join(", ", nums2[index])}, n: {n[index]}");

    int[]? result = MergeSorted.Merge(nums1[index], m[index], nums2[index], n[index]);

    WriteLine($"\tMerged list: {string.Join(", ", result)}");
    WriteLine(new string('-', 100));
}
