// File: TreeNode.cs

namespace TBFSSymmetric.Algo;

public class TreeNode<T>(T data)
{
    public T Data { get; set; } = data;

    public TreeNode<T>? Left { get; set; } = null;

    public TreeNode<T>? Right { get; set; } = null;
}