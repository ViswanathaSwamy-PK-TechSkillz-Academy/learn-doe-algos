from TreeNode import TreeNode

class BinaryTree:
    def __init__(self, list_of_nodes):
        self.root = self.create_binary_tree(list_of_nodes)

    def create_binary_tree(self, list_of_nodes):
        if not list_of_nodes:
            return None

        root = TreeNode(list_of_nodes[0].data)
        queue = [root]

        i = 1
        while i < len(list_of_nodes):
            curr = queue.pop(0)

            if list_of_nodes[i] is not None:
                curr.left = TreeNode(list_of_nodes[i].data)
                queue.append(curr.left)
            i += 1

            if i < len(list_of_nodes) and list_of_nodes[i] is not None:
                curr.right = TreeNode(list_of_nodes[i].data)
                queue.append(curr.right)
            i += 1

        return root
