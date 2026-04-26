namespace _3898_FindTheDegreeOfEachVertex;

public class Solution
{
    public int[] FindDegrees(int[][] matrix)
    {
        int n = matrix.Length;
        var ans = new int[n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                ans[i] += matrix[i][j];
            }
        }

        return ans;
    }

    public int[] FindDegrees2(int[][] matrix) => matrix.Select(row => row.Sum()).ToArray();

    public int[] FindDegrees3(int[][] matrix)
    {
        int n = matrix.Length;
        var ans = new int[n];

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                ans[i] += matrix[i][j];
                ans[j] += matrix[i][j];
            }
        }

        return ans;
    }
}