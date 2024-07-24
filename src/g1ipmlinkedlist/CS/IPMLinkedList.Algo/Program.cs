using IPMLinkedList.Algo;

var input = new[]
        {
            new[] { 1, 2, 3, 4, 5 },
            new[] { 1, 2, 3, 4, 5, 6 },
            new[] { 3, 2, 1 },
            new[] { 10 },
            new[] { 1, 2 }
        };

for (int i = 0; i < input.Length; i++)
{
    var linkedList = new LinkedList();
    linkedList.CreateLinkedList(input[i]);

    Write($"{i + 1}. \tInput linked list: ");
    DisplayLinkedList.DisplayWithForwardArrow(linkedList.Head);

    Write("\tReversed linked list: ");
    DisplayLinkedList.DisplayWithForwardArrow(LinkedList.Reverse(linkedList.Head));

    WriteLine(new string('-', 100));
}