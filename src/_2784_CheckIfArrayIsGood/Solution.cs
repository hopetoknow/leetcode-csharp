namespace _2784_CheckIfArrayIsGood;

public class Solution
{
    public bool IsGood(int[] nums)
    {
        int n = nums.Length;

        if (n < 2)
        {
            return false;
        }

        Array.Sort(nums);

        for (var i = 0; i < n - 1; i++)
        {
            if (nums[i] != i + 1)
            {
                return false;
            }
        }

        return nums[n - 1] == n - 1;
    }
}