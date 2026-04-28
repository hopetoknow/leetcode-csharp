namespace _2176_CountEqualAndDivisiblePairsInAnArray;

public class Solution
{
    public int CountPairs(int[] nums, int k)
    {
        int n = nums.Length;
        int count = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (nums[i] == nums[j] && i * j % k == 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}