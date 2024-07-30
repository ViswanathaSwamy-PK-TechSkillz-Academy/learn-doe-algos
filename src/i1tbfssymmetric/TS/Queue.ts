class Node<T> {
    value: T;
    next: Node<T> | null;

    constructor(value: T) {
        this.value = value;
        this.next = null;
    }
}

export class Queue<T> {
    private head: Node<T> | null;
    private tail: Node<T> | null;
    private size: number;

    constructor() {
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    public getSize(): number {
        return this.size;
    }

    public isEmpty(): boolean {
        return this.size === 0;
    }

    public peek(): T | null {
        if (this.isEmpty()) {
            console.log("QueueEmptyException");
            return null;
        }
        return this.head!.value;
    }

    public enqueue(value: T): void {
        const temp = new Node(value);
        if (this.head === null) {
            this.head = temp;
            this.tail = temp;
        } else {
            this.tail!.next = temp;
            this.tail = temp;
        }
        this.size++;
    }

    public dequeue(): T | null {
        if (this.isEmpty()) {
            console.log("QueueEmptyException");
            return null;
        }
        const value = this.head!.value;
        this.head = this.head!.next;
        this.size--;
        return value;
    }

    public printQueue(): string {
        if (this.size === 0) {
            return "[]";
        }
        let temp = this.head;
        let out = "[";
        while (temp) {
            out += `${temp.value}, `;
            temp = temp.next;
        }
        out = out.slice(0, -2) + "]";
        return out;
    }
}
