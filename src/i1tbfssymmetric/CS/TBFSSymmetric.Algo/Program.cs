using TBFSSymmetric.Algo;

var inputTreesData = new List<List<TreeNode<int>?>>()
{
    new List<TreeNode<int>?> { new TreeNode<int>(1), new TreeNode<int>(2), new TreeNode<int>(2), new TreeNode<int>(3), new TreeNode<int>(4), new TreeNode<int>(4), new TreeNode<int>(3) },
    new List<TreeNode<int>?> { new TreeNode<int>(18), new TreeNode<int>(21), new TreeNode<int>(21), new TreeNode<int>(47), new TreeNode<int>(20), new TreeNode<int>(21), new TreeNode<int>(47) },
    new List<TreeNode<int>?> { new TreeNode<int>(25), new TreeNode<int>(4), new TreeNode<int>(67), new TreeNode<int>(2), new TreeNode<int>(3), new TreeNode<int>(3), new TreeNode<int>(2) },
    new List<TreeNode<int>?> { new TreeNode<int>(1), new TreeNode<int>(2), new TreeNode<int>(2), new TreeNode<int>(3), null, null, new TreeNode<int>(3) },
    new List<TreeNode<int>?> { new TreeNode<int>(1), new TreeNode<int>(2), new TreeNode<int>(2), null, new TreeNode<int>(3), new TreeNode<int>(3), null, new TreeNode<int>(4), new TreeNode<int>(5), new TreeNode<int>(5), new TreeNode<int>(4) }
};

var inputTrees = inputTreesData.Select(treeData => new BinaryTree<int>(treeData)).ToList();

for (int i = 0; i < inputTrees.Count; i++)
{
    var tree = inputTrees[i];
    WriteLine($"{i + 1} .\tInput Tree:");
    DisplayTree(tree.Root);
    WriteLine($"\n\tResult: {SymmetricTreeChecker.IsSymmetric(tree.Root)}");
    WriteLine(new string('-', 100));
}

void DisplayTree(TreeNode<int>? root)
{
    if (root == null) return;
    Write($"{root.Data} ");
    DisplayTree(root.Left);
    DisplayTree(root.Right);
}
