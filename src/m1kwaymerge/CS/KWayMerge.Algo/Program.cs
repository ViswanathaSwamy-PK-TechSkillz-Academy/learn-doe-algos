using MergingLibrary;
using System;

int[][] nums1 = {
    new int[] {23, 33, 35, 41, 44, 47, 56, 91, 105, 0, 0, 0, 0, 0, 0},
    new int[] {1, 2, 0},
    new int[] {1, 1, 1, 0, 0, 0, 0},
    new int[] {6, 0, 0},
    new int[] {12, 34, 45, 56, 67, 78, 89, 99, 0},
};

int[][] nums2 = {
    new int[] {32, 49, 50, 51, 61, 99},
    new int[] {7},
    new int[] {1, 2, 3, 4},
    new int[] {-99, -45},
    new int[] {100},
};

int[] m = { 9, 2, 3, 1, 8 };
int[] n = { 6, 1, 4, 2, 1 };

for (int index = 0; index < m.Length; index++)
{
    Console.WriteLine($"{index + 1}.\tnums1: {string.Join(", ", nums1[index])}, m: {m[index]}");
    Console.WriteLine($"\tnums2: {string.Join(", ", nums2[index])}, n: {n[index]}");
    var result = MergeSorted.Merge(nums1[index], m[index], nums2[index], n[index]);
    Console.WriteLine($"\tMerged list: {string.Join(", ", result)}");
    Console.WriteLine(new string('-', 100));
}
