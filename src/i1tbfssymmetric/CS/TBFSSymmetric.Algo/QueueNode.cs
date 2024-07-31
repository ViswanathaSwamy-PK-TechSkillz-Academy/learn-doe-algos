namespace TBFSSymmetric.Algo;

public class QueueNode<T>
{
    public T Value { get; set; }
    public QueueNode<T>? Next { get; set; }

    public QueueNode(T value)
    {
        Value = value;
        Next = null;
    }
}
