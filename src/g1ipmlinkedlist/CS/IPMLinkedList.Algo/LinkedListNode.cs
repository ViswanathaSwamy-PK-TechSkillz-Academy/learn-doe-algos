// File: LinkedListNode.cs

namespace IPMLinkedList.Algo;

public class LinkedListNode(int data, LinkedListNode? next = null)
{
    public int Data { get; set; } = data;

    public LinkedListNode? Next { get; set; } = next;
}
