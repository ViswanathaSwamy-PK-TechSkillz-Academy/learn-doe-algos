export class TreeNode<T> {
    data: T;
    left: TreeNode<T> | null;
    right: TreeNode<T> | null;

    constructor(data: T) {
        this.data = data;
        this.left = null;
        this.right = null;
    }
}
