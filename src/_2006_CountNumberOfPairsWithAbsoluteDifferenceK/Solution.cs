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

            if (frequencyByNumber.TryGetValue(num, out int value))
            {
                frequencyByNumber[num] = ++value;
            }
            else
            {
                frequencyByNumber[num] = 1;
            }
        }

        return count;
    }
    
    public int CountKDifference3(int[] nums, int k)
    {
        var frequencyByNumber = new Dictionary<int, int>();
        int count = 0;

        foreach (int num in nums)
        {
            frequencyByNumber.TryGetValue(num - k, out int below);
            frequencyByNumber.TryGetValue(num + k, out int above);
            count += below + above;

            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num) + 1;
        }

        return count;
    }
    
    public int CountKDifference4(int[] nums, int k)
    {
        int[] frequencies = new int[101];
        int count = 0;

        foreach (int num in nums)
        {
            if (num >= k) {
                count += frequencies[num - k];                
            }
            
            if (num + k <= 100) 
            {
                count += frequencies[num + k];
            }
            
            frequencies[num]++;
        }

        return count;
    }
}
