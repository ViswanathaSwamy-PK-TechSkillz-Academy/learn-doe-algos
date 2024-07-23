import { LinkedListNode } from './LinkedListNode';

class LinkedList {
    head: LinkedListNode | null;

    constructor() {
        this.head = null;
    }

    insertNodeAtHead(node: LinkedListNode) {
        if (this.head === null) {
            this.head = node;
        } else {
            node.next = this.head;
            this.head = node;
        }
    }

    createLinkedList(arr: number[]) {
        for (let i = arr.length - 1; i >= 0; i--) {
            const newNode = new LinkedListNode(arr[i]);
            this.insertNodeAtHead(newNode);
        }
    }

    displayLinkedList() {
        const elements: number[] = [];
        let temp = this.head;
        while (temp !== null) {
            elements.push(temp.data);
            temp = temp.next;
        }
        console.log(elements);
    }
}

function reverse(head: LinkedListNode | null): LinkedListNode | null {
    let prev: LinkedListNode | null = null;
    let current = head;
    while (current !== null) {
        const next = current.next;
        current.next = prev;
        prev = current;
        current = next;
    }
    return prev;
}

export { LinkedList, reverse };
