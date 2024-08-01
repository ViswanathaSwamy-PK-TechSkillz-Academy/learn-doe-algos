namespace TBFSSymmetric.Algo;

public class BinaryTree<T>
{
    public TreeNode<T>? Root { get; private set; }

    public BinaryTree(List<TreeNode<T>?> listOfNodes)
    {
        Root = CreateBinaryTree(listOfNodes);
    }

    private TreeNode<T>? CreateBinaryTree(List<TreeNode<T>?> listOfNodes)
    {
        if (listOfNodes.Count == 0) return null;

        var root = new TreeNode<T>(listOfNodes[0]!.Data);
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(root);
        int i = 1;

        while (i < listOfNodes.Count)
        {
            var curr = queue.Dequeue();

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
