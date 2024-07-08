namespace StacksRAD.Algo;

public static class RemoveDuplicatesHelper
{
    public static string RemoveDuplicates(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (stack.Count > 0 && stack.Peek() == c)
            {
                stack.Pop(); // pop the last element
            }
            else
            {
                stack.Push(c); // push the current character
            }
        }

        // Convert stack to string
        var resultArray = stack.ToArray();
        Array.Reverse(resultArray); // Stack needs to be reversed to get correct order
        return new string(resultArray);
    }
}
