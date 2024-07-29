class Node:
    def __init__(self, value):
        self.value = value
        self.next = None


class Queue:
    def __init__(self):
        self.head = None
        self.tail = None
        self.size = 0

    def size(self):
        return self.size

    def is_empty(self):
        return self.size == 0

    def peek(self):
        if self.is_empty():
            print("QueueEmptyException")
            return None
        return self.head.value

    def enqueue(self, value):
        temp = Node(value)
        if self.head is None:
            self.head = temp
            self.tail = temp
        else:
            self.tail.next = temp
            self.tail = temp
        self.size += 1

    def dequeue(self):
        if self.is_empty():
            print("QueueEmptyException")
            return None
        value = self.head.value
        self.head = self.head.next
        self.size -= 1
        return value

    def print_queue(self):
        if self.size == 0:
            return "[]"
        temp = self.head
        out = "["
        for _ in range(self.size):
            out += str(temp.value) + ", "
            temp = temp.next
        out = out[:-2]
        out += "]"
        return out
