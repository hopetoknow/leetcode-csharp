namespace _2006_CountNumberOfPairsWithAbsoluteDifferenceK;

public class Solution
{
    public int CountKDifference(int[] nums, int k)
    {
        int n = nums.Length;
        int count = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) == k)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
