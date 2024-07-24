package main

import "fmt"

// LinkedList represents the linked list and includes methods for manipulation.
type LinkedList struct {
	head *LinkedListNode
}

// InsertNodeAtHead inserts a node at the head of the linked list.
func (l *LinkedList) InsertNodeAtHead(node *LinkedListNode) {
	if l.head == nil {
		l.head = node
	} else {
		node.next = l.head
		l.head = node
	}
}

// CreateLinkedList creates a linked list from a slice of integers.
func (l *LinkedList) CreateLinkedList(lst []int) {
	for i := len(lst) - 1; i >= 0; i-- {
		newNode := InitLinkedListNode(lst[i])

		l.InsertNodeAtHead(newNode)
	}
}

// DisplayLinkedList displays the linked list elements as an array.
func (l *LinkedList) DisplayLinkedList() {
	temp := l.head

	fmt.Print("[")
	for temp != nil {
		fmt.Print(temp.data)
		temp = temp.next
		if temp != nil {
			fmt.Print(", ")
		}
	}
	fmt.Print("]")
}

// reverse reverses the linked list in place.
func reverse(head *LinkedListNode) *LinkedListNode {
	var prev, next *LinkedListNode
	current := head

	for current != nil {
		next = current.next
		current.next = prev
		prev = current
		current = next
	}

	return prev
}
