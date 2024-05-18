def find_sum_of_three(nums, target):
    nums.sort()     # Sort the array in ascending order

    for i in range(len(nums) - 2):
        left = i + 1
        right = len(nums) - 1

        while left < right:
            total = nums[i] + nums[left] + nums[right]

            if total == target:
                return True     # Triplet found!
            elif total < target:
                left += 1       # Move left pointer to increase the sum
            else:
                right -= 1      # Move right pointer to decrease the sum

    return False                # No triplet found


# Example usage
nums = [1, 4, 2, 7, 5, 3]
target = 10

print('Sum of Three Numbers:', find_sum_of_three(nums, target))  # Output: True
