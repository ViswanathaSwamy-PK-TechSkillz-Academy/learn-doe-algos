from typing import List

def merge_intervals(intervals: List[List[int]]) -> List[List[int]]:
    if not intervals:
        return []

    result = [intervals[0]]

    for i in range(1, len(intervals)):
        last_added_interval = result[-1]
        cur_start, cur_end = intervals[i]

        if last_added_interval[1] >= cur_start:
            last_added_interval[1] = max(last_added_interval[1], cur_end)
        else:
            result.append(intervals[i])

    return result
