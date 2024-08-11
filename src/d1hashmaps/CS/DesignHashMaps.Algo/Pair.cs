// File: Pair.cs

namespace DesignHashMaps.Algo;

// Pair represents a key-value pair.
public class Pair(int key, int value)
{
    public int Key { get; set; } = key;

    public int Value { get; set; } = value;

    // Override ToString() to provide a string representation of the Pair
    public override string ToString()
    {
        return $"{{key: {Key}, value: {Value}}}";
    }
}
