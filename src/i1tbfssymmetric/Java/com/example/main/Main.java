package com.example.main;

import java.util.Arrays;
import java.util.List;
import com.example.tbfssymmetric.*;

public class Main {

    public static void main(String[] args) {
        List<List<TreeNode<Integer>>> inputTreesData = Arrays.asList(
                Arrays.asList(new TreeNode<>(1), new TreeNode<>(2), new TreeNode<>(2), new TreeNode<>(3), new TreeNode<>(4), new TreeNode<>(4), new TreeNode<>(3)),
                Arrays.asList(new TreeNode<>(18), new TreeNode<>(21), new TreeNode<>(21), new TreeNode<>(47), new TreeNode<>(20), new TreeNode<>(21), new TreeNode<>(47)),
                Arrays.asList(new TreeNode<>(25), new TreeNode<>(4), new TreeNode<>(67), new TreeNode<>(2), new TreeNode<>(3), new TreeNode<>(3), new TreeNode<>(2)),
                Arrays.asList(new TreeNode<>(1), new TreeNode<>(2), new TreeNode<>(2), new TreeNode<>(3), null, null, new TreeNode<>(3)),
                Arrays.asList(new TreeNode<>(1), new TreeNode<>(2), new TreeNode<>(2), null, new TreeNode<>(3), new TreeNode<>(3), null, new TreeNode<>(4), new TreeNode<>(5), new TreeNode<>(5), new TreeNode<>(4))
        );

        inputTreesData.forEach(listOfNodes -> {
            BinaryTree<Integer> tree = new BinaryTree<>(listOfNodes);
            displayTree(tree.root);
            System.out.println("Result: " + SymmetricTreeChecker.isSymmetric(tree.root));
            System.out.println("-".repeat(100));
        });
    }

    public static void displayTree(TreeNode<Integer> root) {
        if (root == null) return;
        System.out.print(root.data + " ");
        displayTree(root.left);
        displayTree(root.right);
    }
}
