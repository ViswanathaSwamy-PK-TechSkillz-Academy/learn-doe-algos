class LinkedListNode:
    def __init__(self, data, next_node=None):
        self.data = data
        self.next = next_node


def new_linked_list_node(data, next_node=None):
    return LinkedListNode(data, next_node)


def init_linked_list_node(data):
    return LinkedListNode(data)
