namespace _1534_CountGoodTriplets;

public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int n = arr.Length;
        int count = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                for (var k = j + 1; k < n; k++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a &&
                        Math.Abs(arr[j] - arr[k]) <= b &&
                        Math.Abs(arr[i] - arr[k]) <= c)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    public int CountGoodTriplets2(int[] arr, int a, int b, int c)
    {
        int n = arr.Length;
        int count = 0;

        for (var i = 0; i < n - 2; i++)
        {
            for (var j = i + 1; j < n - 1; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) > a)
                {
                    continue;
                }

                for (var k = j + 1; k < n; k++)
                {
                    if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}
