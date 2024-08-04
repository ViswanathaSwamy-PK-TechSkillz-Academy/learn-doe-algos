// File: MatrixUtil.cs

namespace MatricesSMZ.Algo;

public static class MatrixUtil
{
    public static void PrintMatrix(int[][] matrix)
    {
        foreach (int[]? row in matrix)
        {
            WriteLine(string.Join(" ", row));
        }
    }
}
