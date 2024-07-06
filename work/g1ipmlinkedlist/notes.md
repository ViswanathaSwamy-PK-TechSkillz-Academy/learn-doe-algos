# In Place Manipulation of Linked List

To perform in-place reversal of a linked list in Go, you need to update the `reverse` function so that it manipulates the linked list nodes to reverse their order. Here’s how you can do it:

## `reverse` Function Implementation

The `reverse` function takes the head of the linked list and reverses it, returning the new head of the reversed list.

### Code Implementation

Here's how you can modify your `reverse` function to achieve in-place reversal:

```go
package main

func reverse(head *EduLinkedListNode) *EduLinkedListNode {
	var prev, next *EduLinkedListNode
	current := head
	for current != nil {
		next = current.next  // store the next node
		current.next = prev  // reverse the link
		prev = current       // move prev and current one step forward
		current = next
	}
	return prev
}
```

### Explanation

1. **Initialize Pointers**:
   - `prev` to `nil` (this will become the new head of the reversed list).
   - `current` to `head` (this is the node we are currently processing).
2. **Iterate Through the List**:
   - Use a loop to go through each node of the list.
   - Inside the loop:
     - Store the next node (`next = current.next`).
     - Reverse the current node's pointer (`current.next = prev`).
     - Move `prev` and `current` one step forward (`prev = current` and `current = next`).
3. **Return the New Head**:
   - Once the loop ends, `prev` will be pointing to the new head of the reversed list.

### Full Code

Here’s how the full program would look with the added `reverse` function:

#### `ll_node.go`

```go
package main

type EduLinkedListNode struct {
	data int
	next *EduLinkedListNode
}

func NewLinkedListNode(data int, next *EduLinkedListNode) *EduLinkedListNode {
	node := new(EduLinkedListNode)
	node.data = data
	node.next = next
	return node
}

func InitLinkedListNode(data int) *EduLinkedListNode {
	node := new(EduLinkedListNode)
	node.data = data
	node.next = nil
	return node
}
```

#### `llist.go`

```go
package main

import (
    "fmt"
)

type EduLinkedList struct {
	head *EduLinkedListNode
}

/* InsertNodeAtHead method will insert a LinkedListNode at head
   of a linked list. */
func (l *EduLinkedList) InsertNodeAtHead(node *EduLinkedListNode) {
	if l.head == nil {
		l.head = node
	} else {
		node.next = l.head
		l.head = node
	}
}

/* CreateLinkedList method will create the linked list using
the given integer array with the help of InsertAtHead method. */
func (l *EduLinkedList) CreateLinkedList(lst []int) {
	for i := len(lst) - 1; i >= 0; i-- {
		newNode := InitLinkedListNode(lst[i])
		l.InsertNodeAtHead(newNode)
	}
}

// DisplayLinkedList method will display the elements of linked list.
func (l *EduLinkedList) DisplayLinkedList() {
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
```

#### `main.go`

```go
package main

import (
	"fmt"
)

func reverse(head *EduLinkedListNode) *EduLinkedListNode {
	var prev, next *EduLinkedListNode
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
	list := EduLinkedList{}
	list.CreateLinkedList([]int{1, 2, 3, 4, 5})

	fmt.Println("Original Linked List:")
	list.DisplayLinkedList()

	// Reverse the linked list
	list.head = reverse(list.head)

	fmt.Println("\nReversed Linked List:")
	list.DisplayLinkedList()
}
```

### Running the Code

When you run this program, it will display the original linked list, reverse it, and then display the reversed linked list.

Output:

```
Original Linked List:
[1, 2, 3, 4, 5]
Reversed Linked List:
[5, 4, 3, 2, 1]
```

This way, you achieve an in-place reversal of the linked list using Go.
