import { TreeNode } from './TreeNode';

export class BinaryTree<T> {
    root: TreeNode<T> | null;

    constructor(listOfNodes: (TreeNode<T> | null)[]) {
        this.root = this.createBinaryTree(listOfNodes);
    }

    private createBinaryTree(listOfNodes: (TreeNode<T> | null)[]): TreeNode<T> | null {
        if (!listOfNodes.length) return null;

        const root = new TreeNode(listOfNodes[0]!.data);
        const queue: TreeNode<T>[] = [root];
        let i = 1;

        while (i < listOfNodes.length) {
            const curr = queue.shift()!;

            if (listOfNodes[i] !== null) {
                curr.left = new TreeNode(listOfNodes[i]!.data);
                queue.push(curr.left);
            }
            i++;

            if (i < listOfNodes.length && listOfNodes[i] !== null) {
                curr.right = new TreeNode(listOfNodes[i]!.data);
                queue.push(curr.right);
            }
            i++;
        }

        return root;
    }
}
