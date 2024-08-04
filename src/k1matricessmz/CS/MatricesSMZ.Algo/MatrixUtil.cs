// File: MatrixUtil.cs

namespace MatricesSMZ.Algo;

public static class MatrixUtil
{
    public static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
