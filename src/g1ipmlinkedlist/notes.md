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


Hello Swamy! In-place manipulation of a linked list refers to modifying the linked list directly without using extra space for another data structure. This is important for efficient memory usage and can involve tasks like reversing the list, removing elements, or reordering the list.

Let's break down some common in-place manipulations of a linked list:

### 1. Reversing a Linked List

To reverse a singly linked list, you need to change the `next` pointers of the nodes so that they point to the previous node instead of the next one.

**Algorithm:**
1. Initialize three pointers: `prev` as `None`, `curr` as `head`, and `next` as `None`.
2. Iterate through the list:
   - Store the next node: `next = curr.next`
   - Reverse the `next` pointer of the current node: `curr.next = prev`
   - Move `prev` and `curr` one step forward: `prev = curr` and `curr = next`
3. Finally, update the `head` to be `prev`.

**Code:**
```python
class ListNode:
    def __init__(self, value=0, next=None):
        self.value = value
        self.next = next

def reverse_linked_list(head):
    prev = None
    curr = head
    while curr:
        next = curr.next
        curr.next = prev
        prev = curr
        curr = next
    return prev
```

### 2. Removing Duplicates from a Sorted Linked List

To remove duplicates from a sorted linked list, you can traverse the list and compare each node with the next one. If they are the same, skip the next node.

**Algorithm:**
1. Start with the head of the list.
2. Iterate through the list:
   - If the current node and the next node have the same value, skip the next node.
   - Otherwise, move to the next node.

**Code:**
```python
def remove_duplicates(head):
    curr = head
    while curr and curr.next:
        if curr.value == curr.next.value:
            curr.next = curr.next.next
        else:
            curr = curr.next
    return head
```

### 3. Detecting a Cycle in a Linked List

To detect a cycle in a linked list, you can use Floyd’s Cycle-Finding Algorithm (Tortoise and Hare).

**Algorithm:**
1. Initialize two pointers: `slow` and `fast`.
2. Move `slow` one step at a time and `fast` two steps at a time.
3. If there is a cycle, `slow` and `fast` will eventually meet.
4. If `fast` reaches the end of the list, there is no cycle.

**Code:**
```python
def has_cycle(head):
    slow = fast = head
    while fast and fast.next:
        slow = slow.next
        fast = fast.next.next
        if slow == fast:
            return True
    return False
```

### 4. Merging Two Sorted Linked Lists

To merge two sorted linked lists into one sorted linked list, you can use a two-pointer technique.

**Algorithm:**
1. Create a dummy node to act as the head of the new list.
2. Use two pointers to traverse the two lists.
3. Compare the values at the two pointers and attach the smaller value to the new list.
4. Move the pointer of the list from which the value was taken.

**Code:**
```python
def merge_two_lists(l1, l2):
    dummy = ListNode()
    curr = dummy
    while l1 and l2:
        if l1.value < l2.value:
            curr.next = l1
            l1 = l1.next
        else:
            curr.next = l2
            l2 = l2.next
        curr = curr.next
    curr.next = l1 if l1 else l2
    return dummy.next
```

### Practice and Further Learning

Practicing these algorithms will help solidify your understanding of in-place manipulation of linked lists. Try implementing variations and more complex manipulations like reordering a list or partitioning it around a value.

Would you like to dive deeper into any specific type of manipulation or problem related to linked lists?