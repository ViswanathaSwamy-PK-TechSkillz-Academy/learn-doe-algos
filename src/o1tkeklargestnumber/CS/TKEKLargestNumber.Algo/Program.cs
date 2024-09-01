using KthLargestElement;

int[] initialNums = { 3, 6, 9, 10 };
Console.WriteLine("Initial stream: " + string.Join(", ", initialNums));
Console.WriteLine("k: 3");

var kLargest = new KthLargest(3, initialNums);

int[] additions = { 4, 7, 10, 8, 15 };
foreach (var val in additions)
{
    Console.WriteLine($"\tAdding a new number {val} to the stream");
    int kthLargest = kLargest.Add(val);
    Console.WriteLine($"\tKth largest element in the stream: {kthLargest}");
    Console.WriteLine(new string('-', 50));
}
