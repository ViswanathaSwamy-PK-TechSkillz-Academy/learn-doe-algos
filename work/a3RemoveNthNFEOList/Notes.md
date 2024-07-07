# Remove nth Node from End of List

## Explanation

1. **LinkedListNode Class**:

   - Defines a node with `data` and `next` properties.

2. **LinkedList Class**:

   - Handles the creation and manipulation of a linked list.

3. **removeNthLastNode Function**:

   - Uses two pointers to find and remove the nth node from the end of the list.
   - Handles cases where `n` is greater than or equal to the length of the list by checking and removing the head node if necessary.

4. **printListWithForwardArrow Function**:

   - Prints the linked list nodes in a visually appealing way with forward arrows.

5. **main Function**:
   - Drives the entire process, creating linked lists, invoking the removal function, and displaying results.

## Usage

> 1. The code is organized into separate files to maintain modularity and ease of testing.
> 1. Each module is imported and used in the `main.js` file to demonstrate the functionality.

```powershell
D:\TSA\learn-doe-algos\src\SumOfThreeValues\JS> node .\main.js

D:\TSA\learn-doe-algos\src\SumOfThreeValues\TS> ts-node .\main.ts
```
