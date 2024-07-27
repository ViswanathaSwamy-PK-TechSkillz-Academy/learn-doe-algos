// File: Program.cs

void DisplayTree<T>(TreeNode<T>? root)
{
    if (root == null) return;

    var queue = new Queue<TreeNode<T>>();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        var current = queue.Dequeue();
        Console.Write($"{current.Data} ");
        if (current.Left != null)
        {
            queue.Enqueue(current.Left);
        }
        if (current.Right != null)
        {
            queue.Enqueue(current.Right);
        }
    }
    Console.WriteLine();
}

var listOfTrees = new List<List<TreeNode<int>?>>()
{
    new() { new TreeNode<int>(2), new TreeNode<int>(1), new TreeNode<int>(4), new TreeNode<int>(3), new TreeNode<int>(5), new TreeNode<int>(6), new TreeNode<int>(7) },
    new() { new TreeNode<int>(1), new TreeNode<int>(2), new TreeNode<int>(3), new TreeNode<int>(4), new TreeNode<int>(5), new TreeNode<int>(6), new TreeNode<int>(7), new TreeNode<int>(8), new TreeNode<int>(9) },
    new() { new TreeNode<int>(45), new TreeNode<int>(32), new TreeNode<int>(23), new TreeNode<int>(21), new TreeNode<int>(19), new TreeNode<int>(19), new TreeNode<int>(18), new TreeNode<int>(1) },
    new() { new TreeNode<int>(5), new TreeNode<int>(3), new TreeNode<int>(4), new TreeNode<int>(1), new TreeNode<int>(2), new TreeNode<int>(6), new TreeNode<int>(7), new TreeNode<int>(8), new TreeNode<int>(9) },
    new() { new TreeNode<int>(9), new TreeNode<int>(7), null, null, new TreeNode<int>(1), new TreeNode<int>(8), new TreeNode<int>(10), null, new TreeNode<int>(12) },
};

var inputTrees = new List<BinaryTree<int>>();
foreach (var listOfNodes in listOfTrees)
{
    inputTrees.Add(new BinaryTree<int>(listOfNodes));
}

for (int i = 0; i < inputTrees.Count; i++)
{
    Console.WriteLine($"{i + 1}.\tOriginal tree:");
    DisplayTree(inputTrees[i].Root);
    Console.WriteLine($"\n\tDiameter of tree: {inputTrees[i].DiameterOfBinaryTree()}");
    Console.WriteLine(new string('-', 100));
}
