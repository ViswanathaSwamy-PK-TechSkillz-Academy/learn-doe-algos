from llist import LinkedList, reverse
from print_llist import display_linked_list_with_forward_arrow


def main():
    input_lists = [
        [1, 2, 3, 4, 5],
        [1, 2, 3, 4, 5, 6],
        [3, 2, 1],
        [10],
        [1, 2],
    ]

    for i, input_list in enumerate(input_lists, 1):
        input_linked_list = LinkedList()
        input_linked_list.create_linked_list(input_list)
        print(f"{i}. \tInput linked list: ", end="")
        display_linked_list_with_forward_arrow(input_linked_list.head)
        print("\n\tReversed linked list: ", end="")
        reversed_head = reverse(input_linked_list.head)
        display_linked_list_with_forward_arrow(reversed_head)
        print("\n" + "-" * 100)


if __name__ == "__main__":
    main()
