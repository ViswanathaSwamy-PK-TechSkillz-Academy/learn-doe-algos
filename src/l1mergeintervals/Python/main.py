from merge_intervals import merge_intervals

input_list = [
    [[1, 5], [3, 7], [4, 6]],
    [[1, 5], [4, 6], [6, 8], [11, 15]],
    [[3, 7], [6, 8], [10, 12], [11, 15]],
    [[1, 5]],
    [[1, 9], [3, 8], [4, 4]],
    [[1, 2], [3, 4], [8, 8]],
    [[1, 5], [1, 3]],
    [[1, 5], [6, 9]],
    [[0, 0], [1, 18], [1, 3]],
]

for index, intervals in enumerate(input_list):
    print(f"{index + 1}. Intervals to merge: {intervals}")
    result = merge_intervals(intervals)
    print(f"Merged intervals: {result}")
    print('-' * 100)
