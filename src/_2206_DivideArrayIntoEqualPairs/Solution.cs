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
    
    
}
