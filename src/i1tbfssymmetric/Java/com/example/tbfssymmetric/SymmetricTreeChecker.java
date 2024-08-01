package com.example.tbfssymmetric;

public class SymmetricTreeChecker {

    public static boolean isSymmetric(TreeNode<Integer> root) {
        if (root == null)
            return true;

        CustomQueue<TreeNode<Integer>> queue = new CustomQueue<>();
        queue.enqueue(root.left);
        queue.enqueue(root.right);

        while (queue.size() > 0) {
            TreeNode<Integer> left = queue.dequeue();
            TreeNode<Integer> right = queue.dequeue();

            if (left == null && right == null)
                continue;
            if (left == null || right == null)
                return false;
            if (!left.data.equals(right.data))
                return false;

            queue.enqueue(left.left);
            queue.enqueue(right.right);
            queue.enqueue(left.right);
            queue.enqueue(right.left);
        }

        return true;
    }
}
