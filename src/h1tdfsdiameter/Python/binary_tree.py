# binary_tree.py

from tree_node import TreeNode


class BinaryTree:
    def __init__(self, list_of_nodes):
        self.root = self.create_binary_tree(list_of_nodes)

    def create_binary_tree(self, list_of_nodes):
        if not list_of_nodes:
            return None

        root = list_of_nodes[0]
        queue = [root]
        i = 1

        while i < len(list_of_nodes):
            curr = queue.pop(0)

            if list_of_nodes[i] is not None:
                curr.left = list_of_nodes[i]
                queue.append(curr.left)
            i += 1

            if i < len(list_of_nodes) and list_of_nodes[i] is not None:
                curr.right = list_of_nodes[i]
                queue.append(curr.right)
            i += 1

        return root

    def diameter_helper(self, node):
        if not node:
            return 0, 0

        left_depth, left_diameter = self.diameter_helper(node.left)
        right_depth, right_diameter = self.diameter_helper(node.right)

        current_diameter = left_depth + right_depth
        max_diameter = max(current_diameter, left_diameter, right_diameter)
        current_depth = 1 + max(left_depth, right_depth)

        return current_depth, max_diameter

    def diameter_of_binary_tree(self):
        if not self.root:
            return 0
        _, diameter = self.diameter_helper(self.root)
        return diameter
