using System.Collections.Generic;

namespace KthLargestElement
{
    public class MinHeap
    {
        private readonly SortedSet<int> _set = new();
        private readonly int _capacity;

        public MinHeap(int capacity)
        {
            _capacity = capacity;
        }

        public int Count => _set.Count;

        public void Add(int value)
        {
            _set.Add(value);
            if (_set.Count > _capacity)
            {
                _set.Remove(_set.Min);
            }
        }

        public int Peek()
        {
            return _set.Min;
        }
    }
}
