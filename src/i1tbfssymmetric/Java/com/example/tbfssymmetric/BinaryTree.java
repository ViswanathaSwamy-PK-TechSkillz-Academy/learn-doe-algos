package com.example.tbfssymmetric;

import java.util.List;
import java.util.LinkedList;
import java.util.Queue;

public class BinaryTree<T> {
    public TreeNode<T> root;

    public BinaryTree(List<TreeNode<T>> listOfNodes) {
        this.root = createBinaryTree(listOfNodes);
    }

    private TreeNode<T> createBinaryTree(List<TreeNode<T>> listOfNodes) {
        if (listOfNodes.isEmpty()) return null;

        TreeNode<T> root = new TreeNode<>(listOfNodes.get(0).data);
        Queue<TreeNode<T>> queue = new LinkedList<>();
        queue.add(root);
        int i = 1;

        while (i < listOfNodes.size()) {
            TreeNode<T> curr = queue.poll();

            if (listOfNodes.get(i) != null) {
                curr.left = new TreeNode<>(listOfNodes.get(i).data);
                queue.add(curr.left);
            }
            i++;

            if (i < listOfNodes.size() && listOfNodes.get(i) != null) {
                curr.right = new TreeNode<>(listOfNodes.get(i).data);
                queue.add(curr.right);
            }
            i++;
        }

        return root;
    }
}
