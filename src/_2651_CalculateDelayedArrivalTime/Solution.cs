namespace _2651_CalculateDelayedArrivalTime;

public class Solution
{
    public int FindNonMinOrMax(int[] nums)
    {
        int n = nums.Length;

        if (n <= 2)
        {
            return -1;
        }

        Array.Sort(nums);
        return nums[n / 2];
    }
}
