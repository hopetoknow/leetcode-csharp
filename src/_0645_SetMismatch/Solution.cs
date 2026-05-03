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

        var ans = new int[2];

        foreach (KeyValuePair<int, int> pair in frequencyByNumber)
        {
            if (pair.Value == 2)
            {
                ans[0] = pair.Key;
                break;
            }
        }

        for (var i = 1; i <= nums.Length; i++)
        {
            if (!frequencyByNumber.ContainsKey(i))
            {
                ans[1] = i;
                break;
            }
        }

        return ans;
    }
}