﻿// File: Program.cs

using StacksRAD.Algo;

List<string> inputs = ["g", "ggaabcdeb", "abbddaccaaabcd", "aannkwwwkkkwna", "abbabccblkklu"];

for (int i = 0; i < inputs.Count; i++)
{
    string input = inputs[i];
    WriteLine($"{i + 1}.\tRemove duplicates from string: \"{input}\"");
    string resultingString = RemoveDuplicatesHelper.RemoveDuplicates(input);
    WriteLine($"\tString after removing duplicates: \"{resultingString}\"");
    WriteLine(new string('-', 100));
}