namespace IPMLinkedList.Algo;

public static class DisplayLinkedList
{
    public static void DisplayWithForwardArrow(LinkedListNode? head)
    {
        var temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data);
            temp = temp.Next;
            if (temp != null)
            {
                Console.Write(" → ");
            }
            else
            {
                Console.Write(" → null");
            }
        }
        Console.WriteLine();
    }
}
