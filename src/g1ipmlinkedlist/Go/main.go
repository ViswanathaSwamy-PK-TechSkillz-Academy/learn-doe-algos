package main

import (
	"fmt"
	"strings"
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
	input := [][]int{
		{1, 2, 3, 4, 5},
		{1, 2, 3, 4, 5, 6},
		{3, 2, 1},
		{10},
		{1, 2},
	}

	for i := 0; i < len(input); i++ {
		inputLinkedList := LinkedList{}

		inputLinkedList.CreateLinkedList(input[i])
		fmt.Printf("%d. \tInput linked list: ", i+1)

		DisplayLinkedListWithForwardArrow(inputLinkedList.head)
		fmt.Printf("\n\tReversed linked list: ")

		DisplayLinkedListWithForwardArrow(reverse(inputLinkedList.head))
		fmt.Printf("\n%s\n", strings.Repeat("-", 100))
	}
}
