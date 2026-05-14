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

    public int[] ConcatWithReverse2(int[] nums) => nums.Concat(nums.Reverse()).ToArray();

    public int[] ConcatWithReverse3(int[] nums)
    {
        int n = nums.Length;
        var ans = new int[2 * n];

        for (int i = 0, j = 2 * n - 1; i < n; i++, j--)
        {
            ans[i] = nums[i];
            ans[j] = nums[i];
        }

        return ans;
    }
}