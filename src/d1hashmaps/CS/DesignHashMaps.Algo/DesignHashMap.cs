using System;

namespace HashMapExample;

// DesignHashMap represents a hash map.
public class DesignHashMap
{
    private int keySpace;
    private Bucket[] buckets; // Array of Buckets

    public DesignHashMap()
    {
        keySpace = 2069;
        buckets = new Bucket[keySpace];
        for (int i = 0; i < keySpace; i++)
        {
            buckets[i] = new Bucket();
        }
    }

    // Put inserts a key-value pair into the hash map or updates the value if the key already exists.
    public void Put(int key, int value)
    {
        int hashKey = key % keySpace;
        buckets[hashKey].Update(key, value);
    }

    // Get returns the value associated with the key if it exists, otherwise returns -1.
    public int Get(int key)
    {
        int hashKey = key % keySpace;
        return buckets[hashKey].Get(key);
    }

    // Remove deletes the key-value pair from the hash map if it exists.
    public void Remove(int key)
    {
        int hashKey = key % keySpace;
        buckets[hashKey].Remove(key);
    }

    // PrintHashMap prints the current state of the hash map.
    public void PrintHashMap()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            if (buckets[i] != null && buckets[i].Count > 0)
            {
                Console.Write($"Bucket {i}: ");
                buckets[i].PrintPairs();
                Console.WriteLine();
            }
        }
    }
}
