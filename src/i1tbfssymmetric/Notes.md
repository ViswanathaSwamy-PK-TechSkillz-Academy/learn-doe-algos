# Tree Breadth-First Search

Welcome back, Swamy! Let's dive into Tree Breadth-First Search (BFS) and Symmetric Tree algorithms.

## Few commands

```powershell

```

### Tree Breadth-First Search (BFS)

Tree BFS is a level-order traversal algorithm. It visits all the nodes at the present depth level before moving on to the nodes at the next depth level.

#### Pseudocode for BFS:

```python
def bfs(root):
    if not root:
        return

    queue = [root]

    while queue:
        node = queue.pop(0)
        print(node.value)

        if node.left:
            queue.append(node.left)
        if node.right:
            queue.append(node.right)
```

#### Python Implementation:

```python
class TreeNode:
    def __init__(self, value=0, left=None, right=None):
        self.value = value
        self.left = left
        self.right = right

def bfs(root):
    if not root:
        return

    queue = [root]

    while queue:
        node = queue.pop(0)
        print(node.value)  # Replace this with any processing of the node

        if node.left:
            queue.append(node.left)
        if node.right:
            queue.append(node.right)
```

### Symmetric Tree

A binary tree is symmetric if the left subtree is a mirror reflection of the right subtree.

#### Recursive Approach

The idea is to write a helper function that compares two nodes to see if they are mirrors of each other.

#### Pseudocode for Symmetric Tree:

```python
def is_symmetric(root):
    if not root:
        return True

    return is_mirror(root.left, root.right)

def is_mirror(left, right):
    if not left and not right:
        return True
    if not left or not right:
        return False
    if left.value != right.value:
        return False

    return is_mirror(left.left, right.right) and is_mirror(left.right, right.left)
```

#### Python Implementation:

```python
class TreeNode:
    def __init__(self, value=0, left=None, right=None):
        self.value = value
        self.left = left
        self.right = right

def is_symmetric(root):
    if not root:
        return True

    return is_mirror(root.left, root.right)

def is_mirror(left, right):
    if not left and not right:
        return True
    if not left or not right:
        return False
    if left.value != right.value:
        return False

    return is_mirror(left.left, right.right) and is_mirror(left.right, right.left)
```

### Example

Here is an example to test both algorithms:

```python
# Creating a symmetric tree
#        1
#      /   \
#     2     2
#    / \   / \
#   3   4 4   3

root = TreeNode(1)
root.left = TreeNode(2)
root.right = TreeNode(2)
root.left.left = TreeNode(3)
root.left.right = TreeNode(4)
root.right.left = TreeNode(4)
root.right.right = TreeNode(3)

# BFS
print("BFS Traversal:")
bfs(root)  # Output: 1 2 2 3 4 4 3

# Symmetric Tree Check
print("Is the tree symmetric?")
print(is_symmetric(root))  # Output: True
```

These implementations should give you a solid foundation to work with Tree BFS and Symmetric Tree algorithms. If you have any specific questions or need further assistance, feel free to ask!
