// File: BinaryTree.go

package main

type BinaryTree[T any] struct {
	root *TreeNode[T]
}

func NewBinaryTree[T any](ListOfNodes []*TreeNode[T]) *BinaryTree[T] {
	tree := &BinaryTree[T]{}
	tree.root = tree.createBinaryTree(ListOfNodes)
	return tree
}

func (tree *BinaryTree[T]) createBinaryTree(ListOfNodes []*TreeNode[T]) *TreeNode[T] {
	if len(ListOfNodes) == 0 {
		return nil
	}

	root := ListOfNodes[0]
	queue := []*TreeNode[T]{root}

	i := 1
	for i < len(ListOfNodes) {
		curr := queue[0]
		queue = queue[1:]

		if ListOfNodes[i] != nil {
			curr.Left = ListOfNodes[i]
			queue = append(queue, curr.Left)
		}
		i++

		if i < len(ListOfNodes) && ListOfNodes[i] != nil {
			curr.Right = ListOfNodes[i]
			queue = append(queue, curr.Right)
		}
		i++
	}

	return root
}

// diameterHelper is a helper function
func (tree *BinaryTree[T]) diameterHelper(node *TreeNode[T], diameter *int) int {
	if node == nil {
		return 0
	}
	lh := tree.diameterHelper(node.Left, diameter)
	rh := tree.diameterHelper(node.Right, diameter)

	*diameter = max(*diameter, lh+rh)
	return max(lh, rh) + 1
}

// DiameterOfBinaryTree calculates the diameter of the binary tree
func (tree *BinaryTree[T]) DiameterOfBinaryTree() int {
	if tree.root == nil {
		return 0
	}
	diameter := 0
	tree.diameterHelper(tree.root, &diameter)
	return diameter
}

// max function returns the maximum of the integers provided
func max(v1 int, v2 int) int {
	if v1 > v2 {
		return v1
	}
	return v2
}
