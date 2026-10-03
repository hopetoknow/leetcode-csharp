namespace _4048_CountValuesWithEquallySpacedOccurrencesI;

public class Solution
{
    public int CountSpecialIntegers(int[] nums)
    {
        var occurrencesByNumber = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!occurrencesByNumber.TryGetValue(nums[i], out List<int>? occurrences))
            {
                occurrences = new List<int>();
                occurrencesByNumber[nums[i]] = occurrences;
            }

            occurrences.Add(i);
        }

        int count = 0;

        foreach (List<int> occurrences in occurrencesByNumber.Values)
        {
            if (occurrences.Count == 3 && occurrences[1] - occurrences[0] == occurrences[2] - occurrences[1])
            {
                count++;
            }
        }

        return count;
    }
}
