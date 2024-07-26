import { TreeNode } from './TreeNode.js';
import { BinaryTree } from './BinaryTree.js';

// Function to display the tree structure (simple level-order traversal for illustration)
function displayTree(root) {
    if (root === null) {
        return;
    }
    let queue = [root];
    while (queue.length > 0) {
        let curr = queue.shift();
        process.stdout.write(curr.data + " ");
        if (curr.left !== null) {
            queue.push(curr.left);
        }
        if (curr.right !== null) {
            queue.push(curr.right);
        }
    }
    console.log();
}

function main() {
    const listOfTrees = [
        [new TreeNode(2), new TreeNode(1), new TreeNode(4), new TreeNode(3), new TreeNode(5), new TreeNode(6), new TreeNode(7)],
        [new TreeNode(1), new TreeNode(2), new TreeNode(3), new TreeNode(4), new TreeNode(5), new TreeNode(6), new TreeNode(7), new TreeNode(8), new TreeNode(9)],
        [new TreeNode(45), new TreeNode(32), new TreeNode(23), new TreeNode(21), new TreeNode(19), new TreeNode(19), new TreeNode(18), new TreeNode(1)],
        [new TreeNode(5), new TreeNode(3), new TreeNode(4), new TreeNode(1), new TreeNode(2), new TreeNode(6), new TreeNode(7), new TreeNode(8), new TreeNode(9)],
        [new TreeNode(9), new TreeNode(7), null, null, new TreeNode(1), new TreeNode(8), new TreeNode(10), null, new TreeNode(12)]
    ];

    const inputTrees = listOfTrees.map(listOfNodes => new BinaryTree(listOfNodes));

    inputTrees.forEach((tree, index) => {
        console.log(`${index + 1}.\tOriginal tree:`);
        displayTree(tree.root);
        console.log(`\tDiameter of tree: ${tree.diameterOfBinaryTree()}`);
        console.log('-'.repeat(100));
    });
}

main();
