// File: Program.cs

using TBFSSymmetric.Algo;

List<List<TreeNode<int>?>>? inputTreesData =
[
    [new(1), new(2), new(2), new(3), new(4), new(4), new(3)],
    [new(18), new(21), new(21), new(47), new(20), new(21), new(47)],
    [new(25), new(4), new(67), new(2), new(3), new(3), new(2)],
    [new(1), new(2), new(2), new(3), null, null, new(3)],
    [new(1), new(2), new(2), null, new(3), new(3), null, new(4), new(5), new(5), new(4)]
];


List<BinaryTree<int>>? inputTrees = inputTreesData.Select(treeData => new BinaryTree<int>(treeData)).ToList();

for (int i = 0; i < inputTrees.Count; i++)
{
    BinaryTree<int>? tree = inputTrees[i];
    WriteLine($"{i + 1} .\tInput Tree:");
    DisplayTree(tree.Root);
    WriteLine($"\n\tResult: {SymmetricTreeChecker.IsSymmetric(tree.Root)}");
    WriteLine(new string('-', 100));
}

static void DisplayTree(TreeNode<int>? root)
{
    if (root == null)
    {
        return;
    }
    Write($"{root.Data} ");
    DisplayTree(root.Left);
    DisplayTree(root.Right);
}
