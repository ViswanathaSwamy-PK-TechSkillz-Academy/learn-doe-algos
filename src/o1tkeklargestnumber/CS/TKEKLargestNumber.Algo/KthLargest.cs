namespace KthLargestElement
{
    public class KthLargest
    {
        private readonly MinHeap _minHeap;

        public KthLargest(int k, int[] nums)
        {
            _minHeap = new MinHeap(k);

            foreach (var num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            _minHeap.Add(val);
            return _minHeap.Peek();
        }
    }
}
