namespace TBFSSymmetric.Algo;

public class CustomQueue<T>
{
    private QueueNode<T>? _head;
    private QueueNode<T>? _tail;
    private int _size;

    public int Size => _size;
    public bool IsEmpty => _size == 0;

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty.");
        return _head!.Value;
    }

    public void Enqueue(T value)
    {
        var temp = new QueueNode<T>(value);
        if (_head == null)
        {
            _head = temp;
            _tail = temp;
        }
        else
        {
            _tail!.Next = temp;
            _tail = temp;
        }
        _size++;
    }

    public T Dequeue()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty.");
        var value = _head!.Value;
        _head = _head.Next;
        _size--;
        return value;
    }

    public override string ToString()
    {
        if (Size == 0) return "[]";
        var temp = _head;
        var outStr = "[";
        while (temp != null)
        {
            outStr += $"{temp.Value}, ";
            temp = temp.Next;
        }
        return outStr.TrimEnd(',', ' ') + "]";
    }
}
