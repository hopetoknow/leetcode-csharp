namespace _2784_CheckIfArrayIsGood;

public class Solution
{
    public bool IsGood(int[] nums)
    {
        int n = nums.Length;

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

    public bool IsGood2(int[] nums)
    {
        var frequencyByNumber = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num) + 1;
        }

        int n = nums.Length;

        for (var i = 1; i < n - 1; i++)
        {
            if (!frequencyByNumber.ContainsKey(i))
            {
                return false;
            }
        }

        return frequencyByNumber.ContainsKey(n - 1) && frequencyByNumber[n - 1] == 2;
    }

    public bool IsGood3(int[] nums)
    {
        var frequencies = new int[201];

        foreach (int num in nums)
        {
            frequencies[num]++;
        }

        int n = nums.Length;

        for (var i = 1; i < n - 1; i++)
        {
            if (frequencies[i] != 1)
            {
                return false;
            }
        }

        return frequencies[n - 1] == 2;
    }
}