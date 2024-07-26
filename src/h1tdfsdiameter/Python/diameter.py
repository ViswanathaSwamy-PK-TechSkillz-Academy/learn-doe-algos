# diameter.py

from tree_node import TreeNode


def diameter_of_binary_tree(root: TreeNode) -> int:
    def dfs(node):
        if not node:
            return 0, 0

        left_depth, left_diameter = dfs(node.left)
        right_depth, right_diameter = dfs(node.right)

        current_diameter = left_depth + right_depth
        max_diameter = max(current_diameter, left_diameter, right_diameter)
        current_depth = 1 + max(left_depth, right_depth)

        return current_depth, max_diameter

    _, diameter = dfs(root)
    return diameter
