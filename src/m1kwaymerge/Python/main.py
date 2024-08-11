# File: main.py

from merge import merge_sorted

nums1 = [
    [23, 33, 35, 41, 44, 47, 56, 91, 105, 0, 0, 0, 0, 0, 0],
    [1, 2, 0],
    [1, 1, 1, 0, 0, 0, 0],
    [6, 0, 0],
    [12, 34, 45, 56, 67, 78, 89, 99, 0],
]
nums2 = [
    [32, 49, 50, 51, 61, 99],
    [7],
    [1, 2, 3, 4],
    [-99, -45],
    [100],
]
m = [9, 2, 3, 1, 8]
n = [6, 1, 4, 2, 1]

for index, value in enumerate(m):
    print(
        f"{index + 1}.\tnums1: {', '.join(map(str, nums1[index]))}, m: {value}")
    print(f"\tnums2: {', '.join(map(str, nums2[index]))}, n: {n[index]}")
    result = merge_sorted(nums1[index], value, nums2[index], n[index])
    print(f"\tMerged list: {', '.join(map(str, result))}")
    print("-" * 100)
