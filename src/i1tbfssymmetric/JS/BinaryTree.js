const TreeNode = require('./TreeNode');

class BinaryTree {
    constructor(listOfNodes) {
        this.root = this.createBinaryTree(listOfNodes);
    }

    createBinaryTree(listOfNodes) {
        if (!listOfNodes.length) return null;

        const root = new TreeNode(listOfNodes[0].data);
        const queue = [root];
        let i = 1;

        while (i < listOfNodes.length) {
            const curr = queue.shift();

            if (listOfNodes[i] !== null) {
                curr.left = new TreeNode(listOfNodes[i].data);
                queue.push(curr.left);
            }
            i++;

            if (i < listOfNodes.length && listOfNodes[i] !== null) {
                curr.right = new TreeNode(listOfNodes[i].data);
                queue.push(curr.right);
            }
            i++;
        }

        return root;
    }
}

module.exports = BinaryTree;
