import { TreeNode } from './TreeNode';

export class BinaryTree<T> {
    root: TreeNode<T> | null;

    constructor(listOfNodes: (TreeNode<T> | null)[]) {
        this.root = this.createBinaryTree(listOfNodes);
    }

    private createBinaryTree(listOfNodes: (TreeNode<T> | null)[]): TreeNode<T> | null {
        if (listOfNodes.length === 0) {
            return null;
        }

        const root = listOfNodes[0];
        if (!root) return null;

        const queue: (TreeNode<T> | null)[] = [root];
        let i = 1;

        while (i < listOfNodes.length) {
            const curr = queue.shift();
            if (!curr) continue;

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

    private diameterHelper(node: TreeNode<T> | null, diameter: { value: number }): number {
        if (node === null) {
            return 0;
        }
        const lh = this.diameterHelper(node.left, diameter);
        const rh = this.diameterHelper(node.right, diameter);

        diameter.value = Math.max(diameter.value, lh + rh);
        return Math.max(lh, rh) + 1;
    }

    diameterOfBinaryTree(): number {
        if (this.root === null) {
            return 0;
        }
        const diameter = { value: 0 };
        this.diameterHelper(this.root, diameter);
        return diameter.value;
    }
}
