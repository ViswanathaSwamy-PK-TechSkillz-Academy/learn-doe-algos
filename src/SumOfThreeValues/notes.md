# Sum Of Three Values Algorithm

1. **Sort the `nums` array in ascending order**:
    - This step ensures that we can efficiently search for the remaining two elements using two pointers.
    - Sorting the array allows us to explore the array in a systematic manner.

1. **Iterate through the array using an outer loop (i)**:
    - Consider each element as a potential first element of the triplet.
    - The outer loop iterates from the beginning of the array to the second-to-last element.

1. **Inside the outer loop, use two pointers (left and right)**:
    - Initialize `left` to the next element after the current `i`.
    - Initialize `right` to the last element of the array.

1. **Find the remaining two elements**:
    - Calculate the sum of the three elements: `sum = nums[i] + nums[left] + nums[right]`.
    - If `sum` equals the target value, we have found a triplet, and we return `true`.
    - If `sum` is less than the target, move the `left` pointer to the right (increasing the sum).
    - If `sum` is greater than the target, move the `right` pointer to the left (decreasing the sum).

1. **Repeat steps 3 and 4**:
    - Continue adjusting the pointers until they meet (i.e., `left >= right`).
    - If we exhaust all possibilities without finding a triplet, return `false`.

This algorithm efficiently identifies whether there exists a triplet in the `nums` array that sums up to the given target value. Feel free to ask if you have any more questions! 😊

> 1. We first sort the nums array in ascending order.
> 1. We iterate through the array using the outer loop (i), considering each element as a potential first element of the triplet.
> 1. Inside the outer loop, we use two pointers (left and right) to find the remaining two elements.
> 1. If the sum of the three elements equals the target, we return true.
> 1. If the sum is less than the target, we move the left pointer to the right (to increase the sum).
> 1. If the sum is greater than the target, we move the right pointer to the left (to decrease the sum).
> 1. If we exhaust all possibilities without finding a triplet, we return false.

```powershell
D:\TSA\learn-doe-algos\src\SumOfThreeValues\JS> node .\main.js

D:\TSA\learn-doe-algos\src\SumOfThreeValues\TS> ts-node .\main.ts
```
