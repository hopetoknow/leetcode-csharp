namespace _1929_ConcatenationOfArray;

public class Solution 
{
    public int[] GetConcatenation(int[] nums) 
    {
        var n = nums.Length;
        var ans = new int[2 * n];

        for (var i = 0; i < n; i++)
        {
            ans[i] = ans[i + n] = nums[i];
        }

        return ans;
    }
}
