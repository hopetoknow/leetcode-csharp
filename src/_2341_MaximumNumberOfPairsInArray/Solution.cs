namespace _2341_MaximumNumberOfPairsInArray;

public class Solution
{
    public int[] NumberOfPairs(int[] nums)
    {
        var frequencyByNumber = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num, 0) + 1;
        }

        int pairs = 0;
        int leftovers = 0;

        foreach (int frequency in frequencyByNumber.Values)
        {
            pairs += frequency / 2;

            if (frequency % 2 != 0)
            {
                leftovers++;
            }
        }

        return [pairs, leftovers];
    }

    public int[] NumberOfPairs2(int[] nums)
    {
        var frequencyByNumber = new Dictionary<int, int>();
        int pairs = 0;

        foreach (int num in nums)
        {
            int count = frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num, 0) + 1;

            if (count % 2 == 0)
            {
                pairs++;
            }
        }

        return [pairs, nums.Length - pairs * 2];
    }
}
