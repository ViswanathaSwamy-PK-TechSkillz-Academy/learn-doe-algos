package com.example.tbfssymmetric;

import java.util.LinkedList;
import java.util.Queue;

public class CustomQueue<T> {
    private Queue<T> queue;

    public CustomQueue() {
        this.queue = new LinkedList<>();
    }

    public int size() {
        return queue.size();
    }

    public boolean isEmpty() {
        return queue.isEmpty();
    }

    public void enqueue(T value) {
        queue.add(value);
    }

    public T dequeue() {
        return queue.poll();
    }

    public T peek() {
        return queue.peek();
    }

    @Override
    public String toString() {
        return queue.toString();
    }
}
