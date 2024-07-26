import { TreeNode } from './TreeNode.js';

export class BinaryTree {
    constructor(listOfNodes) {
        this.root = this.createBinaryTree(listOfNodes);
    }

    createBinaryTree(listOfNodes) {
        if (listOfNodes.length === 0) {
            return null;
        }

        let root = listOfNodes[0];
        let queue = [root];
        let i = 1;

        while (i < listOfNodes.length) {
            let curr = queue.shift();

            if (listOfNodes[i] !== null) {
                curr.left = listOfNodes[i];
                queue.push(curr.left);
            }
            i++;

            if (i < listOfNodes.length && listOfNodes[i] !== null) {
                curr.right = listOfNodes[i];
                queue.push(curr.right);
            }
            i++;
        }

        return root;
    }

    diameterHelper(node, diameter) {
        if (node === null) {
            return 0;
        }
        let lh = this.diameterHelper(node.left, diameter);
        let rh = this.diameterHelper(node.right, diameter);

        diameter.value = Math.max(diameter.value, lh + rh);
        return Math.max(lh, rh) + 1;
    }

    diameterOfBinaryTree() {
        if (this.root === null) {
            return 0;
        }
        let diameter = { value: 0 };
        this.diameterHelper(this.root, diameter);
        return diameter.value;
    }
}
