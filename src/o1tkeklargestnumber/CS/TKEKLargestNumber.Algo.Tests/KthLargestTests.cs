namespace TKEKLargestNumber.Algo.Tests
{
    public class KthLargestTests
    {
        [Fact]
        public void KthLargest_AddsCorrectly()
        {
            var kLargest = new KthLargest(3, new int[] { 3, 6, 9, 10 });
            Assert.Equal(6, kLargest.Add(4));
            Assert.Equal(7, kLargest.Add(7));
            Assert.Equal(9, kLargest.Add(10));
            Assert.Equal(9, kLargest.Add(8));
            Assert.Equal(10, kLargest.Add(15));
        }

        [Fact]
        public void KthLargest_HandlesEmptyInitialArray()
        {
            var kLargest = new KthLargest(1, new int[] { });
            Assert.Equal(4, kLargest.Add(4));
            Assert.Equal(5, kLargest.Add(5));
        }
    }
}
