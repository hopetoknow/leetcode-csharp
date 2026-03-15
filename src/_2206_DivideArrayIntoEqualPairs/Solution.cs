namespace _2206_DivideArrayIntoEqualPairs;

public class Solution
{
    public bool DivideArray(int[] nums)
    {
        var frequencyByNumber = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num, 0) + 1;
        }

        foreach (int frequency in frequencyByNumber.Values)
        {
            if (frequency % 2 != 0)
            {
                return false;
            }
        }

        return true;
    }
    
    public bool DivideArray2(int[] nums)
    {
        var seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (!seen.Add(num))
            {
                seen.Remove(num);
            }
        }

        return seen.Count == 0;
    }
    
    public bool DivideArray3(int[] nums)
    {
        var frequencies = new int[501];

        foreach (int num in nums)
        {
            frequencies[num]++;
        }

        foreach (int frequency in frequencies)
        {
            if (frequency % 2 != 0)
            {
                return false;
            }
        }

        return true;
    }
    
    public bool DivideArray4(int[] nums) => nums.GroupBy(n => n).All(g => g.Count() % 2 == 0);
    
    public bool DivideArray5(int[] nums)
    {
        Array.Sort(nums);

        for (var i = 1; i < nums.Length; i += 2)
        {
            if (nums[i] != nums[i - 1])
            {
                return false;
            }
        }

        return true;
    }
    
    public bool DivideArray6(int[] nums)
    {
        var maxNum = 0;

        foreach (int num in nums)
        {
            maxNum = Math.Max(num, maxNum);
        }

        var seen = new bool[maxNum + 1];

        foreach (int num in nums)
        {
            seen[num] = !seen[num];
        }

        foreach (int num in nums)
        {
            if (seen[num])
            {
                return false;
            }
        }

        return true;
    }
}
