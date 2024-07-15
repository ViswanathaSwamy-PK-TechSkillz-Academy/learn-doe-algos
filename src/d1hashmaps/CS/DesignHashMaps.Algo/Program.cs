using HashMapExample;
using System;

// Driver code
var hashMap = new DesignHashMap();
int[] keys = { 5, 2069, 2070, 2073, 4138, 2068 };
int[] values = { 100, 200, 400, 500, 1000, 5000 };
string[] operations = { "Get", "Get", "Put", "Get", "Put", "Get", "Get", "Remove", "Get", "Get", "Remove", "Get" };
int[][] operationKeys = {
    new int[] { 5 }, new int[] { 2073 }, new int[] { 2073, 250 }, new int[] { 2073 },
    new int[] { 121, 110 }, new int[] { 121 }, new int[] { 2068 }, new int[] { 2069 }, new int[] { 2069 },
    new int[] { 2071 }, new int[] { 2071 }, new int[] { 2071 }
};

// Initialize the hash map with initial keys and values
for (int i = 0; i < keys.Length; i++)
{
    hashMap.Put(keys[i], values[i]);
}

// Execute the operations
for (int i = 0; i < operations.Length; i++)
{
    switch (operations[i])
    {
        case "Put":
            Console.WriteLine($"{i + 1}.\tPut({operationKeys[i][0]}, {operationKeys[i][1]})");
            hashMap.Put(operationKeys[i][0], operationKeys[i][1]);
            break;
        case "Get":
            Console.WriteLine($"{i + 1}.\tGet({operationKeys[i][0]})");
            Console.WriteLine($"\tValue returned: {hashMap.Get(operationKeys[i][0])}");
            break;
        case "Remove":
            Console.WriteLine($"{i + 1}.\tRemove({operationKeys[i][0]})");
            hashMap.Remove(operationKeys[i][0]);
            break;
    }

    // Print the current state of the hash map
    Console.WriteLine("\nCurrent Hash Map:");
    hashMap.PrintHashMap();
    Console.WriteLine(new string('-', 100));
}
