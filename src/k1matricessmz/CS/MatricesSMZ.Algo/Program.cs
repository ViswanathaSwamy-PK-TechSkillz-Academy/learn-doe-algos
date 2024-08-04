using static MatricesSMZ.Algo.MatrixUtil;
using static MatricesSMZ.Algo.Matrix;

var matrices = new List<int[][]>
{
    new[] { new[] {1, 1, 0}, new[] {1, 0, 1}, new[] {1, 1, 1} },
    new[] { new[] {1, 1, 1, 1, 1}, new[] {0, 0, 1, 1, 1}, new[] {1, 1, 1, 1, 0}, new[] {1, 1, 1, 1, 1} },
    new[] { new[] {3, 5, 2, 0}, new[] {1, 0, 4, 6}, new[] {7, 3, 2, 4} },
    new[] { new[] {1, 2, 3, 4}, new[] {4, 5, 6, 7}, new[] {8, 9, 4, 6} },
    new[] { new[] {2, 6, 5, 4, 9, 1}, new[] {7, 2, 0, 0, 5, 4}, new[] {1, 1, 1, 1, 0, 1}, new[] {9, 8, 2, 0, 1, 3}, new[] {7, 8, 6, 5, 4, 3}, new[] {9, 8, 1, 2, 5, 6} }
};

for (int i = 0; i < matrices.Count; i++)
{
    WriteLine($"{i + 1}. \tOriginal Matrix:");
    PrintMatrix(matrices[i]);
    var result = SetMatrixZeros(matrices[i]);
    WriteLine("\n\tMatrix with Zeros:");
    PrintMatrix(result);
    WriteLine(new string('-', 100));
}
