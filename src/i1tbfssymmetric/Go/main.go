package main

import (
	"fmt"
	"strings"
)

// Helper function to display the tree (not included in your original code but useful for visualization)
func displayTree[T any](root *TreeNode[T]) {
	if root == nil {
		return
	}
	fmt.Printf("%v ", root.Data)
	displayTree(root.Left)
	displayTree(root.Right)
}

func main() {
	input := [][]*TreeNode[int]{
		{&TreeNode[int]{Data: 1}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 3}, &TreeNode[int]{Data: 4}, &TreeNode[int]{Data: 4}, &TreeNode[int]{Data: 3}},
		{&TreeNode[int]{Data: 18}, &TreeNode[int]{Data: 21}, &TreeNode[int]{Data: 21}, &TreeNode[int]{Data: 47}, &TreeNode[int]{Data: 20}, &TreeNode[int]{Data: 21}, &TreeNode[int]{Data: 47}},
		{&TreeNode[int]{Data: 25}, &TreeNode[int]{Data: 4}, &TreeNode[int]{Data: 67}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 3}, &TreeNode[int]{Data: 3}, &TreeNode[int]{Data: 2}},
		{&TreeNode[int]{Data: 1}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 3}, nil, nil, &TreeNode[int]{Data: 3}},
		{&TreeNode[int]{Data: 1}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 2}, nil, &TreeNode[int]{Data: 3}, &TreeNode[int]{Data: 3}, nil, &TreeNode[int]{Data: 4}, &TreeNode[int]{Data: 5}, &TreeNode[int]{Data: 5}, &TreeNode[int]{Data: 4}},
	}

	inputTrees := make([]*BinaryTree[int], len(input))
	for i, listOfNodes := range input {
		inputTrees[i] = NewBinaryTree[int](listOfNodes)
	}

	for i, tree := range inputTrees {
		fmt.Printf("%d .\tInput Tree:\n", i+1)
		displayTree(tree.root)
		fmt.Print("\n\tResult: ")
		result := isSymmetric(tree.root)
		fmt.Printf("%t\n", result)
		fmt.Println(strings.Repeat("-", 100))
	}
}
