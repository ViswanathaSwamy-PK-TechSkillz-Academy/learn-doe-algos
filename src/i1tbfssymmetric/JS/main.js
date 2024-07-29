const BinaryTree = require('./BinaryTree');
const TreeNode = require('./TreeNode');
const isSymmetric = require('./SymmetricTree');

function displayTree(root) {
    if (!root) return;
    process.stdout.write(`${root.data} `);
    displayTree(root.left);
    displayTree(root.right);
}

function main() {
    const inputTreesData = [
        [new TreeNode(1), new TreeNode(2), new TreeNode(2), new TreeNode(3), new TreeNode(4), new TreeNode(4), new TreeNode(3)],
        [new TreeNode(18), new TreeNode(21), new TreeNode(21), new TreeNode(47), new TreeNode(20), new TreeNode(21), new TreeNode(47)],
        [new TreeNode(25), new TreeNode(4), new TreeNode(67), new TreeNode(2), new TreeNode(3), new TreeNode(3), new TreeNode(2)],
        [new TreeNode(1), new TreeNode(2), new TreeNode(2), new TreeNode(3), null, null, new TreeNode(3)],
        [new TreeNode(1), new TreeNode(2), new TreeNode(2), null, new TreeNode(3), new TreeNode(3), null, new TreeNode(4), new TreeNode(5), new TreeNode(5), new TreeNode(4)],
    ];

    const inputTrees = inputTreesData.map(treeData => new BinaryTree(treeData));

    inputTrees.forEach((tree, i) => {
        console.log(`${i + 1} .\tInput Tree:`);
        displayTree(tree.root);
        console.log("\n\tResult:", isSymmetric(tree.root));
        console.log("-".repeat(100));
    });
}

main();
