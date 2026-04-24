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
}