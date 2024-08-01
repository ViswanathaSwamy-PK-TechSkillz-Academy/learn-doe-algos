namespace TBFSSymmetric.Algo;

public static class SymmetricTreeChecker
{
    public static bool IsSymmetric(TreeNode<int>? root)
    {
        if (root == null) return true;

        var queue = new CustomQueue<TreeNode<int>?>();
        queue.Enqueue(root.Left);
        queue.Enqueue(root.Right);

        while (queue.Size > 0)
        {
            var left = queue.Dequeue();
            var right = queue.Dequeue();

            if (left == null && right == null) continue;
            if (left == null || right == null) return false;
            if (!left.Data.Equals(right.Data)) return false;

            queue.Enqueue(left.Left);
            queue.Enqueue(right.Right);
            queue.Enqueue(left.Right);
            queue.Enqueue(right.Left);
        }

        return true;
    }
}
