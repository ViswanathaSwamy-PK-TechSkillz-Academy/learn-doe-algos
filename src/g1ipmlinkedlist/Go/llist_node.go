package main

// LinkedListNode defines the structure of a node in the linked list.
type LinkedListNode struct {
	data int
	next *LinkedListNode
}

// NewLinkedListNode initializes a new node with given data and next pointer.
func NewLinkedListNode(data int, next *LinkedListNode) *LinkedListNode {
	node := new(LinkedListNode)

	node.data = data
	node.next = next

	return node
}

// InitLinkedListNode initializes a new node with given data and no next pointer.
func InitLinkedListNode(data int) *LinkedListNode {
	node := new(LinkedListNode)

	node.data = data
	node.next = nil

	return node
}
