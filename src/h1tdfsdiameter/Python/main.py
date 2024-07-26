# main.py

from tree_node import TreeNode
from diameter import diameter_of_binary_tree


def main():
    # Example trees:
    # Tree 1:
    #      1
    #     / \
    #    2   3
    #   / \
    #  4   5
    root1 = TreeNode(1, TreeNode(2, TreeNode(4), TreeNode(5)), TreeNode(3))

    # Tree 2:
    #       1
    #      / \
    #     2   3
    #    / \
    #   4   5
    #  /
    # 6
    root2 = TreeNode(1, TreeNode(2, TreeNode(
        4, TreeNode(6)), TreeNode(5)), TreeNode(3))

    # Tree 3:
    #      1
    #     / \
    #    2   3
    #   /     \
    #  4       5
    root3 = TreeNode(1, TreeNode(2, TreeNode(4)),
                     TreeNode(3, None, TreeNode(5)))

    print("Diameter of Tree 1:", diameter_of_binary_tree(root1))  # Output: 3
    print("Diameter of Tree 2:", diameter_of_binary_tree(root2))  # Output: 4
    print("Diameter of Tree 3:", diameter_of_binary_tree(root3))  # Output: 3


if __name__ == "__main__":
    main()
