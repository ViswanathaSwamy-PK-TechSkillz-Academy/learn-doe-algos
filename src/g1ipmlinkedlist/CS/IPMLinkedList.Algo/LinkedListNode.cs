namespace IPMLinkedList.Algo;

public class LinkedListNode
{
    public int Data { get; set; }
    public LinkedListNode? Next { get; set; }

    public LinkedListNode(int data, LinkedListNode? next = null)
    {
        Data = data;
        Next = next;
    }
}
