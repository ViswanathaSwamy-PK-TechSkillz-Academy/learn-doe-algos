// File: TreeNode.cs

namespace TDFSDiameter.Algo;

public class TreeNode<T>(T data)
{
    public T Data { get; set; } = data;

    public TreeNode<T>? Left { get; set; }

    public TreeNode<T>? Right { get; set; }
}
