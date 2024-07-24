package com.example.main;

import com.example.ipmlinkedlist.*;

// File: Main.java
public class Main {
    public static void main(String[] args) {
        int[][] input = {
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5, 6 },
                { 3, 2, 1 },
                { 10 },
                { 1, 2 }
        };

        for (int i = 0; i < input.length; i++) {
            LinkedList linkedList = new LinkedList();
            linkedList.createLinkedList(input[i]);
            System.out.print((i + 1) + ". \tInput linked list: ");
            DisplayLinkedList.displayWithForwardArrow(linkedList.head);
            System.out.print("\tReversed linked list: ");
            DisplayLinkedList.displayWithForwardArrow(LinkedList.reverse(linkedList.head));
            System.out.println(new String(new char[100]).replace('\0', '-'));
        }
    }
}
