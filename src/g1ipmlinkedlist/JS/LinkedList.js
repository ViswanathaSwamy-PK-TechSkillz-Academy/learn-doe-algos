const LinkedListNode = require('./LinkedListNode');

class LinkedList {
    constructor() {
        this.head = null;
    }

    insertNodeAtHead(node) {
        if (this.head === null) {
            this.head = node;
        } else {
            node.next = this.head;
            this.head = node;
        }
    }

    createLinkedList(arr) {
        for (let i = arr.length - 1; i >= 0; i--) {
            const newNode = new LinkedListNode(arr[i]);
            this.insertNodeAtHead(newNode);
        }
    }

    displayLinkedList() {
        const elements = [];
        let temp = this.head;
        while (temp !== null) {
            elements.push(temp.data);
            temp = temp.next;
        }
        console.log(elements);
    }
}

function reverse(head) {
    let prev = null;
    let current = head;
    while (current !== null) {
        const next = current.next;
        current.next = prev;
        prev = current;
        current = next;
    }
    return prev;
}

module.exports = { LinkedList, reverse };
