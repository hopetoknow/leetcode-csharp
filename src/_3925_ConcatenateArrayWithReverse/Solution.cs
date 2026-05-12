namespace _3925_ConcatenateArrayWithReverse;

public class Solution
{
    public int[] ConcatWithReverse(int[] nums)
    {
        int n = nums.Length;
        var ans = new int[2 * n];

        for (var i = 0; i < n; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[n - i - 1];
        }

        return ans;
    }
}