namespace TKEKLargestNumber.Algo;

public class KthLargest
{
    private readonly MinHeap _minHeap;

    public KthLargest(int k, int[] numbers)
    {
        _minHeap = new MinHeap(k);

        foreach (var number in numbers)
        {
            Add(number);
        }
    }

    public int Add(int val)
    {
        _minHeap.Add(val);

        return _minHeap.Peek();
    }
}
