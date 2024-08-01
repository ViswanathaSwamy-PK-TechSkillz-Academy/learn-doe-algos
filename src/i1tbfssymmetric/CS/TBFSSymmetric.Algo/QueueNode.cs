namespace TBFSSymmetric.Algo;

public class QueueNode<T>(T value)
{
    public T Value { get; set; } = value;

    public QueueNode<T>? Next { get; set; } = null;
}
