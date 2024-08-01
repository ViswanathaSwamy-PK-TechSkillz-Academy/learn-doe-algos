// File: BinaryTree.cs

namespace TBFSSymmetric.Algo;

public class BinaryTree<T>(List<TreeNode<T>?> listOfNodes)
{
    public TreeNode<T>? Root { get; private set; } = BinaryTree<T>.CreateBinaryTree(listOfNodes);

    private static TreeNode<T>? CreateBinaryTree(List<TreeNode<T>?> listOfNodes)
    {
        if (listOfNodes.Count == 0)
        {
            return null;
        }

        TreeNode<T>? root = new(listOfNodes[0]!.Data);
        Queue<TreeNode<T>>? queue = new();
        queue.Enqueue(root);
        int i = 1;

        while (i < listOfNodes.Count)
        {
            TreeNode<T>? curr = queue.Dequeue();

            if (listOfNodes[i] != null)
            {
                curr.Left = new TreeNode<T>(listOfNodes[i]!.Data);
                queue.Enqueue(curr.Left);
            }
            i++;

            if (i < listOfNodes.Count && listOfNodes[i] != null)
            {
                curr.Right = new TreeNode<T>(listOfNodes[i]!.Data);
                queue.Enqueue(curr.Right);
            }
            i++;
        }

        return root;
    }
}
