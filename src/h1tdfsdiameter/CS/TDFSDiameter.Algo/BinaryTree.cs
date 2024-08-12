// File: BinaryTree.cs

namespace TDFSDiameter.Algo;

public class BinaryTree<T>(List<TreeNode<T>?> listOfNodes)
{
    public TreeNode<T>? Root { get; private set; } = BinaryTree<T>.CreateBinaryTree(listOfNodes);

    private static TreeNode<T>? CreateBinaryTree(List<TreeNode<T>?> listOfNodes)
    {
        if (listOfNodes == null || listOfNodes.Count == 0 || listOfNodes[0] == null)
        {
            return null;
        }

        TreeNode<T>? root = listOfNodes[0];
        Queue<TreeNode<T>> queue = new();
        queue.Enqueue(root!);

        int i = 1;
        while (i < listOfNodes.Count)
        {
            TreeNode<T>? current = queue.Dequeue();

            if (i < listOfNodes.Count && listOfNodes[i] != null)
            {
                current.Left = listOfNodes[i];
                queue.Enqueue(current.Left!);
            }
            i++;

            if (i < listOfNodes.Count && listOfNodes[i] != null)
            {
                current.Right = listOfNodes[i];
                queue.Enqueue(current.Right!);
            }
            i++;
        }

        return root;
    }

    private static int DiameterHelper(TreeNode<T>? node, ref int diameter)
    {
        if (node == null)
        {
            return 0;
        }

        int leftHeight = BinaryTree<T>.DiameterHelper(node.Left, ref diameter);
        int rightHeight = BinaryTree<T>.DiameterHelper(node.Right, ref diameter);

        diameter = Math.Max(diameter, leftHeight + rightHeight);

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    public int DiameterOfBinaryTree()
    {
        int diameter = 0;

        if (Root != null)
        {
            BinaryTree<T>.DiameterHelper(Root, ref diameter);
        }

        return diameter;
    }
}
