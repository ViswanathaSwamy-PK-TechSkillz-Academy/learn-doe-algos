namespace IPMLinkedList.Algo;

public class LinkedList
{
    public LinkedListNode? Head { get; set; }

    public void InsertNodeAtHead(LinkedListNode node)
    {
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }
    }

    public void CreateLinkedList(int[] values)
    {
        for (int i = values.Length - 1; i >= 0; i--)
        {
            var newNode = new LinkedListNode(values[i]);
            InsertNodeAtHead(newNode);
        }
    }

    public void DisplayLinkedList()
    {
        var temp = Head;
        Write("[");
        while (temp != null)
        {
            Write(temp.Data);
            temp = temp.Next;
            if (temp != null)
            {
                Write(", ");
            }
        }
        WriteLine("]");
    }

    public static LinkedListNode? Reverse(LinkedListNode? head)
    {
        LinkedListNode? prev = null;
        LinkedListNode? current = head;

        while (current != null)
        {
            var next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}
