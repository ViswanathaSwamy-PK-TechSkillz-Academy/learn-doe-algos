// File: Program.cs

using FindDifference;

string[] string1List = { "wxyz", "cbda", "jlkmn", "courae", "hello" };
string[] string2List = { "zwxgy", "abc", "klmn", "couearg", "helo" };

for (int i = 0; i < string1List.Length; i++)
{
    Console.WriteLine($"{i + 1}.\tString 1 = {string1List[i]}");
    Console.WriteLine($"\tString 2 = {string2List[i]}");
    Console.WriteLine($"\n\tThe extra character is at index: {DifferenceFinder.ExtraCharacterIndex(string1List[i], string2List[i])}");
    Console.WriteLine(new string('-', 100));
}