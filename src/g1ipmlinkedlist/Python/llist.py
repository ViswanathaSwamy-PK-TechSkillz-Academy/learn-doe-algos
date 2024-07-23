from llist_node import init_linked_list_node


class LinkedList:
    def __init__(self):
        self.head = None

    def insert_node_at_head(self, node):
        if self.head is None:
            self.head = node
        else:
            node.next = self.head
            self.head = node

    def create_linked_list(self, lst):
        for i in reversed(lst):
            new_node = init_linked_list_node(i)
            self.insert_node_at_head(new_node)

    def display_linked_list(self):
        temp = self.head
        elements = []
        while temp is not None:
            elements.append(temp.data)
            temp = temp.next
        print(elements)


def reverse(head):
    prev = None
    current = head
    while current is not None:
        next_node = current.next
        current.next = prev
        prev = current
        current = next_node
    return prev
