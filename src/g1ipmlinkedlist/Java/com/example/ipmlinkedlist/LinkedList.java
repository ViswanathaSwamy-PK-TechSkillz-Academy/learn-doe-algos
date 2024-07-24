// File: LinkedList.java

package com.example.ipmlinkedlist;

public class LinkedList {
    LinkedListNode head;

    public void insertNodeAtHead(LinkedListNode node) {
        if (head == null) {
            head = node;
        } else {
            node.next = head;
            head = node;
        }
    }

    public void createLinkedList(int[] values) {
        for (int i = values.length - 1; i >= 0; i--) {
            LinkedListNode newNode = new LinkedListNode(values[i]);
            insertNodeAtHead(newNode);
        }
    }

    public void displayLinkedList() {
        LinkedListNode temp = head;
        System.out.print("[");
        while (temp != null) {
            System.out.print(temp.data);
            temp = temp.next;
            if (temp != null) {
                System.out.print(", ");
            }
        }
        System.out.println("]");
    }

    public static LinkedListNode reverse(LinkedListNode head) {
        LinkedListNode prev = null;
        LinkedListNode current = head;

        while (current != null) {
            LinkedListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}
