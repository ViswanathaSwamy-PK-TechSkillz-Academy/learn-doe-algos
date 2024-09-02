using TKEKLargestNumber.Algo;

int[] initialNumbers = [3, 6, 9, 10];
WriteLine("Initial stream: " + string.Join(", ", initialNumbers));
WriteLine("k: 3");

KthLargest kLargest = new(3, initialNumbers);

int[] additions = [4, 7, 10, 8, 15];
foreach (int value in additions)
{
    WriteLine($"\tAdding a new number {value} to the stream");

    int kthLargest = kLargest.Add(value);
    WriteLine($"\tKth largest element in the stream: {kthLargest}");
    WriteLine(new string('-', 50));
}
