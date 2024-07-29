package main

func isSymmetric(root *TreeNode[int]) bool {
	queue := &Queue{}
	queue.Enqueue(root.Left)
	queue.Enqueue(root.Right)

	for queue.Size() > 0 {
		left := queue.Dequeue().(*TreeNode[int])
		right := queue.Dequeue().(*TreeNode[int])

		if left == nil && right == nil {
			continue
		}
		if left == nil || right == nil {
			return false
		}
		if left.Data != right.Data {
			return false
		}

		queue.Enqueue(left.Left)
		queue.Enqueue(right.Right)
		queue.Enqueue(left.Right)
		queue.Enqueue(right.Left)
	}
	return true
}
