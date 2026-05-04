namespace _0645_SetMismatch;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var frequencyByNumber = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num) + 1;
        }

        int missing = -1;
        int duplicate = -1;

        for (var i = 1; i <= nums.Length; i++)
        {
            if (!frequencyByNumber.TryGetValue(i, out int frequency))
            {
                missing = i;
            }
            else if (frequency == 2)
            {
                duplicate = i;
            }

            if (missing != -1 && duplicate != -1)
            {
                break;
            }
        }

        return [duplicate, missing];
    }

    public int[] FindErrorNums2(int[] nums)
    {
        int n = nums.Length;
        var frequencies = new int[n + 1];

        foreach (int num in nums)
        {
            frequencies[num]++;
        }

        int duplicate = -1;
        int missing = -1;

        for (var i = 1; i <= n; i++)
        {
            if (frequencies[i] == 2)
            {
                duplicate = i;
            }
            else if (frequencies[i] == 0)
            {
                missing = i;
            }

            if (duplicate != -1 && missing != -1)
            {
                break;
            }
        }

        return [duplicate, missing];
    }
}