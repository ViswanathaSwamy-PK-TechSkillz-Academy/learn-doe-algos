// File: MergeSorted.cs

namespace KWayMerge.Algo;

public static class MergeSorted
{
    public static int[] Merge(int[] numbers1, int m, int[] numbers2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;

        for (int p = n + m - 1; p >= 0; p--)
        {
            if (p2 < 0)
            {
                break;
            }

            if (p1 >= 0 && numbers1[p1] > numbers2[p2])
            {
                numbers1[p] = numbers1[p1];
                p1--;
            }
            else
            {
                numbers1[p] = numbers2[p2];
                p2--;
            }
        }

        return numbers1;
    }
}
