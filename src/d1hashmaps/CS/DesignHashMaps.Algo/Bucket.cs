// File: Bucket.cs

namespace DesignHashMaps.Algo;

// Bucket represents a bucket for storing key-value pairs.
public class Bucket
{
    private readonly List<Pair> pairs; // List to store key-value pairs

    public Bucket()
    {
        pairs = []; // Initialize the list
    }

    // Get returns the value associated with the key if it exists, otherwise returns -1.
    public int Get(int key)
    {
        foreach (Pair? pair in pairs)
        {
            if (pair.Key == key)
            {
                return pair.Value;
            }
        }

        return -1;
    }

    // Update inserts a key-value pair into the bucket, or updates the value if the key already exists.
    public void Update(int key, int value)
    {
        for (int i = 0; i < pairs.Count; i++)
        {
            if (pairs[i].Key == key)
            {
                pairs[i].Value = value;
                return;
            }
        }

        pairs.Add(new Pair(key, value));
    }

    // Remove deletes the key-value pair from the bucket if it exists.
    public void Remove(int key)
    {
        pairs.RemoveAll(pair => pair.Key == key);
    }

    // Property to get the count of pairs in the bucket.
    public int Count => pairs.Count;

    // PrintPairs prints the key-value pairs in the bucket.
    public void PrintPairs()
    {
        foreach (Pair? pair in pairs)
        {
            Write($"{pair} ");
        }
    }
}
