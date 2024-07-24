package main

import (
	"fmt"
)

/*
DisplayLinkedListWithForwardArrow method will display the linked list not in the form of an array, but rather a list with
arrows pointing to the next element
*/
func DisplayLinkedListWithForwardArrow(l *LinkedListNode) {
	temp := l
	for temp != nil {
		fmt.Print(temp.data)
		temp = temp.next
		if temp != nil {
			fmt.Print(" → ")
		} else {
			fmt.Print(" → null")
		}
	}
}
