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
}
