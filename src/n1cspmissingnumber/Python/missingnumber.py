# File: missingnumber.py

def find_missing_number(nums):
    len_nums = len(nums)
    index = 0

    while index < len_nums:
        value = nums[index]
        if value < len_nums and value != nums[value]:
            nums[index], nums[value] = nums[value], nums[index]
        else:
            index += 1

    for i, x in enumerate(nums):
        if i != x:
            return i

    return len_nums
