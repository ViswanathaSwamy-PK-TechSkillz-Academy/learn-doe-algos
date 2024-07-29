const Queue = require('./Queue');

function isSymmetric(root) {
    const queue = new Queue();
    queue.enqueue(root.left);
    queue.enqueue(root.right);

    while (queue.size > 0) {
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

module.exports = isSymmetric;
