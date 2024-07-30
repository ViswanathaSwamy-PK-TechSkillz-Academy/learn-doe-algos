class Node {
    constructor(value) {
        this.value = value;
        this.next = null;
    }
}

class Queue {
    constructor() {
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    isEmpty() {
        return this.size === 0;
    }

    peek() {
        if (this.isEmpty()) {
            console.log("QueueEmptyException");
            return null;
        }
        return this.head.value;
    }

    enqueue(value) {
        const temp = new Node(value);
        if (this.head === null) {
            this.head = temp;
            this.tail = temp;
        } else {
            this.tail.next = temp;
            this.tail = temp;
        }
        this.size++;
    }

    dequeue() {
        if (this.isEmpty()) {
            console.log("QueueEmptyException");
            return null;
        }
        const value = this.head.value;
        this.head = this.head.next;
        this.size--;
        return value;
    }

    printQueue() {
        if (this.size === 0) {
            return "[]";
        }
        let temp = this.head;
        let out = "[";
        for (let i = 0; i < this.size; i++) {
            out += temp.value + ", ";
            temp = temp.next;
        }
        out = out.slice(0, -2) + "]";
        return out;
    }
}

module.exports = Queue;
