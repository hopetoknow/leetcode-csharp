namespace _1637_WidestVerticalAreaBetweenTwoPointsContainingNoPoints;

public class Solution
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        int n = points.Length;
        var xs = new int[n];

        for (var i = 0; i < n; i++)
        {
            xs[i] = points[i][0];
        }

        Array.Sort(xs);

        int widestArea = 0;

        for (var i = 1; i < n; i++)
        {
            int area = xs[i] - xs[i - 1];

            if (widestArea < area)
            {
                widestArea = area;
            }
        }

        return widestArea;
    }

    public int MaxWidthOfVerticalArea2(int[][] points)
    {
        var xs = points.Select(p => p[0]).OrderBy(x => x).ToArray();

        int widestArea = 0;

        for (var i = 1; i < points.Length; i++)
        {
            widestArea = Math.Max(widestArea, xs[i] - xs[i - 1]);
        }

        return widestArea;
    }

    public int MaxWidthOfVerticalArea3(int[][] points)
    {
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

        int widestArea = 0;

        for (var i = 1; i < points.Length; i++)
        {
            widestArea = Math.Max(widestArea, points[i][0] - points[i - 1][0]);
        }

        return widestArea;
    }
}