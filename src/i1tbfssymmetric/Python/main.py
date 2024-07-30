from BinaryTree import BinaryTree
from TreeNode import TreeNode
from SymmetricTree import is_symmetric


def display_tree(root):
    if root is None:
        return
    print(root.data, end=" ")
    display_tree(root.left)
    display_tree(root.right)


def main():
    input_trees_data = [
        [TreeNode(1), TreeNode(2), TreeNode(2), TreeNode(
            3), TreeNode(4), TreeNode(4), TreeNode(3)],
        [TreeNode(18), TreeNode(21), TreeNode(21), TreeNode(
            47), TreeNode(20), TreeNode(21), TreeNode(47)],
        [TreeNode(25), TreeNode(4), TreeNode(67), TreeNode(
            2), TreeNode(3), TreeNode(3), TreeNode(2)],
        [TreeNode(1), TreeNode(2), TreeNode(2),
         TreeNode(3), None, None, TreeNode(3)],
        [TreeNode(1), TreeNode(2), TreeNode(2), None, TreeNode(3), TreeNode(
            3), None, TreeNode(4), TreeNode(5), TreeNode(5), TreeNode(4)]
    ]

    input_trees = [BinaryTree(tree_data) for tree_data in input_trees_data]

    for i, tree in enumerate(input_trees):
        print(f"{i + 1} .\tInput Tree:")
        display_tree(tree.root)
        print("\n\tResult:", is_symmetric(tree.root))
        print("-" * 100)


if __name__ == "__main__":
    main()
