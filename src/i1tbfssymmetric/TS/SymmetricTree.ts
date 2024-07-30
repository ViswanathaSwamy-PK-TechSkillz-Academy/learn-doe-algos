import { TreeNode } from './TreeNode';
import { Queue } from './Queue';

export function isSymmetric(root: TreeNode<number>): boolean {
    const queue = new Queue<TreeNode<number> | null>();
    queue.enqueue(root.left);
    queue.enqueue(root.right);

    while (queue.getSize() > 0) {
        const left = queue.dequeue();
        const right = queue.dequeue();

        if (left === null && right === null) {
            continue;
        }
        if (left === null || right === null) {
            return false;
        }
        if (left.data !== right.data) {
            return false;
        }

        queue.enqueue(left.left);
        queue.enqueue(right.right);
        queue.enqueue(left.right);
        queue.enqueue(right.left);
    }
    return true;
}
