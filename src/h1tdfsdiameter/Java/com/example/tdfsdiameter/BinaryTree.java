package com.example.tdfsdiameter;

import java.util.*;

public class BinaryTree<T> {
    public TreeNode<T> root;

    public BinaryTree(List<TreeNode<T>> listOfNodes) {
        root = createBinaryTree(listOfNodes);
    }

    private TreeNode<T> createBinaryTree(List<TreeNode<T>> listOfNodes) {
        if (listOfNodes == null || listOfNodes.isEmpty()) {
            return null;
        }

        TreeNode<T> root = listOfNodes.get(0);
        Queue<TreeNode<T>> queue = new LinkedList<>();
        queue.offer(root);

        int i = 1;
        while (i < listOfNodes.size()) {
            TreeNode<T> current = queue.poll();

            if (i < listOfNodes.size() && listOfNodes.get(i) != null) {
                current.left = listOfNodes.get(i);
                queue.offer(current.left);
            }
            i++;

            if (i < listOfNodes.size() && listOfNodes.get(i) != null) {
                current.right = listOfNodes.get(i);
                queue.offer(current.right);
            }
            i++;
        }

        return root;
    }

    private int diameterHelper(TreeNode<T> node, int[] diameter) {
        if (node == null) {
            return 0;
        }

        int leftHeight = diameterHelper(node.left, diameter);
        int rightHeight = diameterHelper(node.right, diameter);

        diameter[0] = Math.max(diameter[0], leftHeight + rightHeight);

        return Math.max(leftHeight, rightHeight) + 1;
    }

    public int diameterOfBinaryTree() {
        int[] diameter = new int[1];
        diameterHelper(root, diameter);
        return diameter[0];
    }
}
