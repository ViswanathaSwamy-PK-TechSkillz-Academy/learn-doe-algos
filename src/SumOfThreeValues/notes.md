# Sum Of Three Values Algorithm

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
