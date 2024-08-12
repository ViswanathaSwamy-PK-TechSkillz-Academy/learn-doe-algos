// File: DesignHashMap.cs

namespace DesignHashMaps.Algo;

// DesignHashMap represents a hash map.
public class DesignHashMap
{
    private readonly int keySpace;
    private readonly Bucket[] buckets; // Array of Buckets

    public DesignHashMap()
    {
        keySpace = 2069;
        buckets = new Bucket[keySpace];

        for (int i = 0; i < keySpace; i++)
        {
            buckets[i] = new Bucket();
        }
    }

    // Private method to calculate the hash key
    private int GetHashKey(int key) => key % keySpace;

    // Put inserts a key-value pair into the hash map or updates the value if the key already exists.
    public void Put(int key, int value)
    {
        int hashKey = GetHashKey(key);

        buckets[hashKey].Update(key, value);
    }

    // Get returns the value associated with the key if it exists, otherwise returns -1.
    public int Get(int key)
    {
        int hashKey = GetHashKey(key);

        return buckets[hashKey].Get(key);
    }

    // Remove deletes the key-value pair from the hash map if it exists.
    public void Remove(int key)
    {
        int hashKey = GetHashKey(key);

        buckets[hashKey].Remove(key);
    }

    // PrintHashMap prints the current state of the hash map.
    public void PrintHashMap()
    {
        for (int i = 0; i < buckets.Length; i++)
        {
            if (buckets[i] != null && buckets[i].Count > 0)
            {
                Write($"Bucket {i}: ");
                buckets[i].PrintPairs();
                WriteLine();
            }
        }
    }
}
