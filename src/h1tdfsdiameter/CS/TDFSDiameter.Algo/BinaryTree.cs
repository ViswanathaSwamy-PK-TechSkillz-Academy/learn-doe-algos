// File: BinaryTree.cs

using System;
using System.Collections.Generic;

public class BinaryTree<T>
{
    public TreeNode<T> Root { get; private set; }

    public BinaryTree(List<TreeNode<T>> listOfNodes)
    {
        Root = CreateBinaryTree(listOfNodes);
    }

    private TreeNode<T> CreateBinaryTree(List<TreeNode<T>> listOfNodes)
    {
        if (listOfNodes == null || listOfNodes.Count == 0)
        {
            return null;
        }

        var root = listOfNodes[0];
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(root);

        int i = 1;
        while (i < listOfNodes.Count)
        {
            var current = queue.Dequeue();

            if (i < listOfNodes.Count && listOfNodes[i] != null)
            {
                current.Left = listOfNodes[i];
                queue.Enqueue(current.Left);
            }
            i++;

            if (i < listOfNodes.Count && listOfNodes[i] != null)
            {
                current.Right = listOfNodes[i];
                queue.Enqueue(current.Right);
            }
            i++;
        }

        return root;
    }

    private int DiameterHelper(TreeNode<T> node, ref int diameter)
    {
        if (node == null)
        {
            return 0;
        }

        int leftHeight = DiameterHelper(node.Left, ref diameter);
        int rightHeight = DiameterHelper(node.Right, ref diameter);

        diameter = Math.Max(diameter, leftHeight + rightHeight);

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    public int DiameterOfBinaryTree()
    {
        int diameter = 0;
        DiameterHelper(Root, ref diameter);
        return diameter;
    }
}
