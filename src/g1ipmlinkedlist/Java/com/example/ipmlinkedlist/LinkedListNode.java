// File: LinkedListNode.java

package com.example.ipmlinkedlist;

public class LinkedListNode {
    int data;
    LinkedListNode next;

    public LinkedListNode(int data, LinkedListNode next) {
        this.data = data;
        this.next = next;
    }

    public LinkedListNode(int data) {
        this(data, null);
    }
}
