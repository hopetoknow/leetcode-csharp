namespace _4048_CountValuesWithEquallySpacedOccurrencesI;

public class Solution
{
    public int CountSpecialIntegers(int[] nums)
    {
        var occurrencesByNumber = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Length; i++)
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

    public int CountSpecialIntegers2(int[] nums)
    {
        int n = 101;
        var counts = new int[n];
        var occurrences = new int[n, 3];

        for (var i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (counts[num] < 3)
            {
                occurrences[num, counts[num]] = i;
            }

            counts[num]++;
        }

        int count = 0;

        for (var i = 0; i < n; i++)
        {
            if (counts[i] == 3 && occurrences[i, 1] - occurrences[i, 0] == occurrences[i, 2] - occurrences[i, 1])
            {
                count++;
            }
        }

        return count;
    }
}
