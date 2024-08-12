// File: Program.cs

using TDFSDiameter.Algo;

static void DisplayTree<T>(TreeNode<T>? root)
{
    if (root == null)
    {
        return;
    }

    Queue<TreeNode<T>>? queue = new();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        TreeNode<T>? current = queue.Dequeue();

        Write($"{current.Data} ");
        if (current.Left != null)
        {
            queue.Enqueue(current.Left);
        }
        if (current.Right != null)
        {
            queue.Enqueue(current.Right);
        }
    }
    WriteLine();
}

List<List<TreeNode<int>?>> listOfTrees =
[
    [new TreeNode<int>(2), new TreeNode<int>(1), new TreeNode<int>(4), new TreeNode<int>(3), new TreeNode<int>(5), new TreeNode<int>(6), new TreeNode<int>(7)],
    [new TreeNode<int>(1), new TreeNode<int>(2), new TreeNode<int>(3), new TreeNode<int>(4), new TreeNode<int>(5), new TreeNode<int>(6), new TreeNode<int>(7), new TreeNode<int>(8), new TreeNode<int>(9)],
    [new TreeNode<int>(45), new TreeNode<int>(32), new TreeNode<int>(23), new TreeNode<int>(21), new TreeNode<int>(19), new TreeNode<int>(19), new TreeNode<int>(18), new TreeNode<int>(1)],
    [new TreeNode<int>(5), new TreeNode<int>(3), new TreeNode<int>(4), new TreeNode<int>(1), new TreeNode<int>(2), new TreeNode<int>(6), new TreeNode<int>(7), new TreeNode<int>(8), new TreeNode<int>(9)],
    [new TreeNode<int>(9), new TreeNode<int>(7), null, null, new TreeNode<int>(1), new TreeNode<int>(8), new TreeNode<int>(10), null, new TreeNode<int>(12)],
];

List<BinaryTree<int>> inputTrees = [];
foreach (List<TreeNode<int>?> listOfNodes in listOfTrees)
{
    inputTrees.Add(new BinaryTree<int>(listOfNodes));
}

for (int i = 0; i < inputTrees.Count; i++)
{
    WriteLine($"{i + 1}.\tOriginal tree:");
    DisplayTree(inputTrees[i].Root);
    WriteLine($"\n\tDiameter of tree: {inputTrees[i].DiameterOfBinaryTree()}");
    WriteLine(new string('-', 100));
}
