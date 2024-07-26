# main.py

from tree_node import TreeNode
from binary_tree import BinaryTree


def display_tree(root):
    if root is None:
        return
    queue = [root]
    result = []
    while queue:
        curr = queue.pop(0)
        result.append(curr.data)
        if curr.left is not None:
            queue.append(curr.left)
        if curr.right is not None:
            queue.append(curr.right)
    print(" ".join(map(str, result)))


def main():
    # Create sample trees
    list_of_trees = [
        [TreeNode(2), TreeNode(1), TreeNode(4), TreeNode(
            3), TreeNode(5), TreeNode(6), TreeNode(7)],
        [TreeNode(1), TreeNode(2), TreeNode(3), TreeNode(4), TreeNode(
            5), TreeNode(6), TreeNode(7), TreeNode(8), TreeNode(9)],
        [TreeNode(45), TreeNode(32), TreeNode(23), TreeNode(21),
         TreeNode(19), TreeNode(19), TreeNode(18), TreeNode(1)],
        [TreeNode(5), TreeNode(3), TreeNode(4), TreeNode(1), TreeNode(
            2), TreeNode(6), TreeNode(7), TreeNode(8), TreeNode(9)],
        [TreeNode(9), TreeNode(7), None, None, TreeNode(1),
         TreeNode(8), TreeNode(10), None, TreeNode(12)]
    ]

    input_trees = [BinaryTree(list_of_nodes)
                   for list_of_nodes in list_of_trees]

    for index, tree in enumerate(input_trees):
        print(f"{index + 1}.\tOriginal tree:")
        display_tree(tree.root)
        print(f"\tDiameter of tree: {tree.diameter_of_binary_tree()}")
        print('-' * 100)


if __name__ == "__main__":
    main()
