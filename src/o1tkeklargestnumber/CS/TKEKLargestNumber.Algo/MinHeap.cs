namespace TKEKLargestNumber.Algo;

public class MinHeap(int capacity)
{
    private readonly PriorityQueue<int, int> _queue = new();
    private readonly int _capacity = capacity;

    public int Count => _queue.Count;

    public void Add(int value)
    {
        _queue.Enqueue(value, value);

        if (_queue.Count > _capacity)
        {
            _queue.Dequeue();
        }
    }

    public int Peek()
    {
        return _queue.Peek();
    }
}
