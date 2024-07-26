# Tree Depth First Search

Sure, Swamy! Let's break down the problem and create a Go implementation for calculating the diameter of a binary tree using DFS. We will structure the code across multiple files for better organization.

## Implementation

### File Structure

1. `main.go` - Entry point of the application.
2. `tree/node.go` - Definition of the tree node structure.
3. `tree/diameter.go` - Logic for calculating the diameter of the binary tree.

### `main.go`

```go
package main

import (
    "fmt"
    "goland/tree"
)

func main() {
    root := &tree.TreeNode{Val: 1}
    root.Left = &tree.TreeNode{Val: 2}
    root.Right = &tree.TreeNode{Val: 3}
    root.Left.Left = &tree.TreeNode{Val: 4}
    root.Left.Right = &tree.TreeNode{Val: 5}
    root.Right.Right = &tree.TreeNode{Val: 6}

    diameter := tree.DiameterOfBinaryTree(root)
    fmt.Printf("Diameter of the binary tree: %d\n", diameter)
}
```

### `tree/node.go`

```go
package tree

// TreeNode represents a node in a binary tree.
type TreeNode struct {
    Val   int
    Left  *TreeNode
    Right *TreeNode
}
```

### `tree/diameter.go`

```go
package tree

// max is a helper function to return the maximum of two integers.
func max(a, b int) int {
    if a > b {
        return a
    }
    return b
}

// heightAndDiameter computes the height and updates the diameter of the binary tree.
func heightAndDiameter(root *TreeNode, diameter *int) int {
    if root == nil {
        return 0
    }

    leftHeight := heightAndDiameter(root.Left, diameter)
    rightHeight := heightAndDiameter(root.Right, diameter)

    // Update the diameter if the path through root is larger.
    *diameter = max(*diameter, leftHeight+rightHeight)

    // Return the height of the tree.
    return max(leftHeight, rightHeight) + 1
}

// DiameterOfBinaryTree computes the diameter of a binary tree.
func DiameterOfBinaryTree(root *TreeNode) int {
    diameter := 0
    heightAndDiameter(root, &diameter)
    return diameter
}
```

### Explanation

1. **TreeNode Struct**: Represents a node in the binary tree, defined in `tree/node.go`.
2. **Height and Diameter Calculation**: The `heightAndDiameter` function computes the height of the tree while updating the diameter. The diameter is the longest path between any two nodes in the tree, which may or may not pass through the root.
3. **Diameter Function**: The `DiameterOfBinaryTree` function initializes the diameter to zero and uses the `heightAndDiameter` function to calculate the diameter of the tree.

This code is designed to be modular and easy to understand, with separate files for the main application, the tree node structure, and the diameter calculation logic.

A binary tree is a data structure in which each node has at most two children, referred to as the left child and the right child. It is a hierarchical structure, commonly used in computer science for various purposes, such as searching, sorting, and representing hierarchical data.

### Key Concepts of a Binary Tree

1. **Node**: The basic unit of a binary tree, containing a value and pointers to its children.
2. **Root**: The topmost node in a binary tree. It is the only node that does not have a parent.
3. **Child**: A node directly connected to another node when moving away from the root.
4. **Parent**: A node directly connected to another node when moving towards the root.
5. **Leaf**: A node that does not have any children.
6. **Subtree**: A tree formed by a node and its descendants.
7. **Height**: The number of edges on the longest path from a node to a leaf. The height of a binary tree is the height of its root node.

### Types of Binary Trees

1. **Full Binary Tree**: Every node other than the leaves has two children.
2. **Complete Binary Tree**: All levels are fully filled except possibly the last level, which is filled from left to right.
3. **Perfect Binary Tree**: All internal nodes have two children, and all leaves are at the same level.
4. **Balanced Binary Tree**: The difference between the heights of the left and right subtrees of any node is no more than one.
5. **Binary Search Tree (BST)**: A binary tree in which for each node, the left subtree contains only nodes with values less than the node’s value, and the right subtree contains only nodes with values greater than the node’s value.

### Example

Here's an example of a binary tree:

```
        1
       / \
      2   3
     / \   \
    4   5   6
```

In this tree:

- The root node is `1`.
- The left child of `1` is `2`, and the right child is `3`.
- The left child of `2` is `4`, and the right child is `5`.
- The right child of `3` is `6`.
- Nodes `4`, `5`, and `6` are leaves.

Binary trees are fundamental in various algorithms and are used as the basis for more complex data structures like binary heaps, AVL trees, and red-black trees.

A Binary Search Tree (BST) is a type of binary tree that maintains a specific order property, making it useful for efficient searching, insertion, and deletion operations. The defining property of a BST is:

### Binary Search Tree Property

For every node in the tree:

- The left subtree of the node contains only nodes with values less than the node’s value.
- The right subtree of the node contains only nodes with values greater than the node’s value.
- Both the left and right subtrees must also be binary search trees.

### Key Operations

1. **Search**: Determines whether a value exists in the tree.
2. **Insertion**: Adds a new value to the tree while maintaining the BST property.
3. **Deletion**: Removes a value from the tree while maintaining the BST property.

### Example

Here is an example of a BST:

```
        8
       / \
      3   10
     / \    \
    1   6    14
       / \   /
      4   7 13
```

In this tree:

- The root node is `8`.
- The left subtree of `8` contains values less than `8`.
- The right subtree of `8` contains values greater than `8`.
- This property holds true for all subtrees as well.

### Operations in a BST

#### Search

To search for a value in a BST:

1. Start at the root.
2. If the value equals the root's value, the search is successful.
3. If the value is less than the root's value, search the left subtree.
4. If the value is greater than the root's value, search the right subtree.
5. Repeat the process until the value is found or the subtree is `null`.

#### Insertion

To insert a new value in a BST:

1. Start at the root.
2. If the new value is less than the root's value, go to the left subtree.
3. If the new value is greater than the root's value, go to the right subtree.
4. Repeat the process until you find an appropriate `null` position.
5. Insert the new value at this position.

#### Deletion

To delete a value from a BST, there are three possible scenarios:

1. **Node to be deleted is a leaf**: Simply remove the node.
2. **Node to be deleted has one child**: Remove the node and replace it with its child.
3. **Node to be deleted has two children**: Find the node's in-order predecessor (largest value in the left subtree) or in-order successor (smallest value in the right subtree), swap values, and then delete the predecessor or successor.

### Example Code in Go

Here's a simple implementation of a BST in Go:

#### `main.go`

```go
package main

import (
    "fmt"
    "goland/bst"
)

func main() {
    root := &bst.TreeNode{Val: 8}
    bst.Insert(root, 3)
    bst.Insert(root, 10)
    bst.Insert(root, 1)
    bst.Insert(root, 6)
    bst.Insert(root, 4)
    bst.Insert(root, 7)
    bst.Insert(root, 14)
    bst.Insert(root, 13)

    fmt.Println("In-Order Traversal of BST:")
    bst.InOrderTraversal(root)

    fmt.Println("\nSearching for value 6 in BST:")
    if bst.Search(root, 6) != nil {
        fmt.Println("Value 6 found in BST.")
    } else {
        fmt.Println("Value 6 not found in BST.")
    }

    fmt.Println("\nDeleting value 10 from BST:")
    root = bst.Delete(root, 10)
    fmt.Println("In-Order Traversal after deletion:")
    bst.InOrderTraversal(root)
}
```

#### `bst/node.go`

```go
package bst

// TreeNode represents a node in a binary search tree.
type TreeNode struct {
    Val   int
    Left  *TreeNode
    Right *TreeNode
}
```

#### `bst/operations.go`

```go
package bst

import "fmt"

// Insert inserts a new value into the BST.
func Insert(root *TreeNode, val int) *TreeNode {
    if root == nil {
        return &TreeNode{Val: val}
    }
    if val < root.Val {
        root.Left = Insert(root.Left, val)
    } else {
        root.Right = Insert(root.Right, val)
    }
    return root
}

// Search searches for a value in the BST.
func Search(root *TreeNode, val int) *TreeNode {
    if root == nil || root.Val == val {
        return root
    }
    if val < root.Val {
        return Search(root.Left, val)
    }
    return Search(root.Right, val)
}

// Delete deletes a value from the BST.
func Delete(root *TreeNode, val int) *TreeNode {
    if root == nil {
        return nil
    }
    if val < root.Val {
        root.Left = Delete(root.Left, val)
    } else if val > root.Val {
        root.Right = Delete(root.Right, val)
    } else {
        if root.Left == nil {
            return root.Right
        } else if root.Right == nil {
            return root.Left
        }
        minNode := findMin(root.Right)
        root.Val = minNode.Val
        root.Right = Delete(root.Right, minNode.Val)
    }
    return root
}

// findMin finds the node with the minimum value in the BST.
func findMin(root *TreeNode) *TreeNode {
    current := root
    for current.Left != nil {
        current = current.Left
    }
    return current
}

// InOrderTraversal performs an in-order traversal of the BST.
func InOrderTraversal(root *TreeNode) {
    if root != nil {
        InOrderTraversal(root.Left)
        fmt.Print(root.Val, " ")
        InOrderTraversal(root.Right)
    }
}
```

This implementation covers the basic operations of a BST: insertion, searching, deletion, and in-order traversal. The code is structured into multiple files for better organization.
