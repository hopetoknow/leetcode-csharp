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
}
