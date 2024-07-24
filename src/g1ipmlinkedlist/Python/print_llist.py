def display_linked_list_with_forward_arrow(head):
    temp = head
    while temp is not None:
        print(temp.data, end="")
        temp = temp.next
        if temp is not None:
            print(" → ", end="")
        else:
            print(" → null", end="")
