// File: DisplayLinkedList.java

package com.example.ipmlinkedlist;

public class DisplayLinkedList {
    public static void displayWithForwardArrow(LinkedListNode head) {
        LinkedListNode temp = head;
        while (temp != null) {
            System.out.print(temp.data);
            temp = temp.next;
            if (temp != null) {
                System.out.print(" → ");
            } else {
                System.out.print(" → null");
            }
        }
        System.out.println();
    }
}
