package main

import (
	"fmt"
)

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

func main() {
	// Create a linked list
	list := LinkedList{}
	list.CreateLinkedList([]int{1, 2, 3, 4, 5})

	fmt.Println("Original Linked List:")
	list.DisplayLinkedList()

	// Reverse the linked list
	list.head = reverse(list.head)

	fmt.Println("\nReversed Linked List:")
	list.DisplayLinkedList()
}
