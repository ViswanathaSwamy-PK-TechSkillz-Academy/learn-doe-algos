from Queue import Queue
from TreeNode import TreeNode


def is_symmetric(root):
    queue = Queue()
    queue.enqueue(root.left)
    queue.enqueue(root.right)

    while queue.size > 0:
        left = queue.dequeue()
        right = queue.dequeue()

        if left is None and right is None:
            continue
        if left is None or right is None:
            return False
        if left.data != right.data:
            return False

        queue.enqueue(left.left)
        queue.enqueue(right.right)
        queue.enqueue(left.right)
        queue.enqueue(right.left)

    return True
