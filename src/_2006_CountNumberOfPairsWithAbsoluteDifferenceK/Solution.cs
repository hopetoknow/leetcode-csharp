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
    
    public int CountKDifference2(int[] nums, int k)
    {
        var frequencyByNumber = new Dictionary<int, int>();
        int count = 0;

        foreach (int num in nums)
        {
            if (frequencyByNumber.ContainsKey(num - k))
            {
                count += frequencyByNumber[num - k];
            }

            if (frequencyByNumber.ContainsKey(num + k))
            {
                count += frequencyByNumber[num + k];
            }

            if (frequencyByNumber.ContainsKey(num))
            {
                frequencyByNumber[num]++;
            }
            else
            {
                frequencyByNumber[num] = 1;
            }
        }

        return count;
    }
}
