class LinkedListNode {
    data: number;
    next: LinkedListNode | null;

    constructor(data: number, next: LinkedListNode | null = null) {
        this.data = data;
        this.next = next;
    }
}

export { LinkedListNode };
