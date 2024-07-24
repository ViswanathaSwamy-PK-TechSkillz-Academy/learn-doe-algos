namespace IPMLinkedList.Algo;

public static class DisplayLinkedList
{
    public static void DisplayWithForwardArrow(LinkedListNode? head)
    {
        var temp = head;
        while (temp != null)
        {
            Write(temp.Data);
            temp = temp.Next;
            if (temp != null)
            {
                Write(" → ");
            }
            else
            {
                Write(" → null");
            }
        }
        WriteLine();
    }
}
