package com.example.main;

import java.util.*;
import com.example.tdfsdiameter.*;

public class Main {
    public static void displayTree(TreeNode<?> root) {
        if (root == null) {
            return;
        }
        Queue<TreeNode<?>> queue = new LinkedList<>();
        queue.offer(root);
        while (!queue.isEmpty()) {
            TreeNode<?> current = queue.poll();
            System.out.print(current.data + " ");
            if (current.left != null) {
                queue.offer(current.left);
            }
            if (current.right != null) {
                queue.offer(current.right);
            }
        }
        System.out.println();
    }

    public static void main(String[] args) {
        List<List<TreeNode<Integer>>> listOfTrees = Arrays.asList(
            Arrays.asList(new TreeNode<>(2), new TreeNode<>(1), new TreeNode<>(4), new TreeNode<>(3), new TreeNode<>(5), new TreeNode<>(6), new TreeNode<>(7)),
            Arrays.asList(new TreeNode<>(1), new TreeNode<>(2), new TreeNode<>(3), new TreeNode<>(4), new TreeNode<>(5), new TreeNode<>(6), new TreeNode<>(7), new TreeNode<>(8), new TreeNode<>(9)),
            Arrays.asList(new TreeNode<>(45), new TreeNode<>(32), new TreeNode<>(23), new TreeNode<>(21), new TreeNode<>(19), new TreeNode<>(19), new TreeNode<>(18), new TreeNode<>(1)),
            Arrays.asList(new TreeNode<>(5), new TreeNode<>(3), new TreeNode<>(4), new TreeNode<>(1), new TreeNode<>(2), new TreeNode<>(6), new TreeNode<>(7), new TreeNode<>(8), new TreeNode<>(9)),
            Arrays.asList(new TreeNode<>(9), new TreeNode<>(7), null, null, new TreeNode<>(1), new TreeNode<>(8), new TreeNode<>(10), null, new TreeNode<>(12))
        );

        List<BinaryTree<Integer>> inputTrees = new ArrayList<>();
        for (List<TreeNode<Integer>> listOfNodes : listOfTrees) {
            inputTrees.add(new BinaryTree<>(listOfNodes));
        }

        for (int i = 0; i < inputTrees.size(); i++) {
            BinaryTree<Integer> tree = inputTrees.get(i);
            System.out.printf("%d.\tOriginal tree:\n", i + 1);
            displayTree(tree.root);
            System.out.printf("\n\tDiameter of tree: %d\n", tree.diameterOfBinaryTree());
            System.out.println("-".repeat(100));
        }
    }
}
