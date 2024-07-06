using FSP.Algo;

int[] inputs = { 1, 5, 19, 25, 7 };

foreach (int input in inputs)
{
    WriteLine($"Input Number: {input}");
    WriteLine($"Is it a happy number? {HappyNumberHelper.IsHappyNumber(input)}");
    WriteLine(new string('-', 50));
}