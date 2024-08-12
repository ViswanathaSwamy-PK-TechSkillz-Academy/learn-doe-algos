using IPMLinkedList.Algo;
using System.Text;

int[][] inputs = [[1, 2, 3, 4, 5], [1, 2, 3, 4, 5, 6], [3, 2, 1], [10], [1, 2]];

for (int i = 0; i < inputs.Length; i++)
{
    LinkedList linkedList = new();
    linkedList.CreateLinkedList(inputs[i]);

    OutputEncoding = Encoding.UTF8;
    Write($"{i + 1}. \tInput linked list: ");
    DisplayLinkedList.DisplayWithForwardArrow(linkedList.Head);

    Write("\tReversed linked list: ");
    DisplayLinkedList.DisplayWithForwardArrow(LinkedList.Reverse(linkedList.Head));

    WriteLine(new string('-', 100));
}