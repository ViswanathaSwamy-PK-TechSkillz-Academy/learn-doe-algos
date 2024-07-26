package main

import (
	"fmt"
	"strings"
)

// displayTree prints the tree structure (a simple example for illustration)
func displayTree[T any](root *TreeNode[T]) {
	if root == nil {
		return
	}
	queue := []*TreeNode[T]{root}
	for len(queue) > 0 {
		curr := queue[0]
		queue = queue[1:]
		fmt.Print(curr.Data, " ")
		if curr.Left != nil {
			queue = append(queue, curr.Left)
		}
		if curr.Right != nil {
			queue = append(queue, curr.Right)
		}
	}
	fmt.Println()
}

func main() {
	listOfTrees := [][]*TreeNode[int]{
		{&TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 1}, &TreeNode[int]{Data: 4}, &TreeNode[int]{Data: 3}, &TreeNode[int]{Data: 5}, &TreeNode[int]{Data: 6}, &TreeNode[int]{Data: 7}},
		{&TreeNode[int]{Data: 1}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 3}, &TreeNode[int]{Data: 4}, &TreeNode[int]{Data: 5}, &TreeNode[int]{Data: 6}, &TreeNode[int]{Data: 7}, &TreeNode[int]{Data: 8}, &TreeNode[int]{Data: 9}},
		{&TreeNode[int]{Data: 45}, &TreeNode[int]{Data: 32}, &TreeNode[int]{Data: 23}, &TreeNode[int]{Data: 21}, &TreeNode[int]{Data: 19}, &TreeNode[int]{Data: 19}, &TreeNode[int]{Data: 18}, &TreeNode[int]{Data: 1}},
		{&TreeNode[int]{Data: 5}, &TreeNode[int]{Data: 3}, &TreeNode[int]{Data: 4}, &TreeNode[int]{Data: 1}, &TreeNode[int]{Data: 2}, &TreeNode[int]{Data: 6}, &TreeNode[int]{Data: 7}, &TreeNode[int]{Data: 8}, &TreeNode[int]{Data: 9}},
		{&TreeNode[int]{Data: 9}, &TreeNode[int]{Data: 7}, nil, nil, &TreeNode[int]{Data: 1}, &TreeNode[int]{Data: 8}, &TreeNode[int]{Data: 10}, nil, &TreeNode[int]{Data: 12}},
	}

	inputTrees := make([]*BinaryTree[int], len(listOfTrees))
	for i, listOfNodes := range listOfTrees {
		inputTrees[i] = NewBinaryTree(listOfNodes)
	}

	for i, tree := range inputTrees {
		fmt.Printf("%d.\tOriginal tree:\n", i+1)
		displayTree(tree.root)
		fmt.Printf("\n\tDiameter of tree: %d\n", tree.DiameterOfBinaryTree())
		fmt.Printf("%s\n", strings.Repeat("-", 100))
	}
}
