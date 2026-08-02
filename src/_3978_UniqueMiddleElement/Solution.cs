namespace _3978_UniqueMiddleElement;

public class Solution
{
    public bool IsMiddleElementUnique(int[] nums)
    {
        var frequencyByNumber = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num, 0) + 1;
        }

        int middle = nums[nums.Length / 2];

        return frequencyByNumber[middle] == 1;
    }

    public bool IsMiddleElementUnique2(int[] nums)
    {
        var frequencyByNumber = new Dictionary<int, int>();
        int middle = nums[nums.Length / 2];

        foreach (int num in nums)
        {
            int frequency = frequencyByNumber.GetValueOrDefault(num, 0) + 1;
            frequencyByNumber[num] = frequency;

            if (num == middle && frequency > 1)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsMiddleElementUnique3(int[] nums)
    {
        int middle = nums[nums.Length / 2];
        var seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (num == middle && !seen.Add(num))
            {
                return false;
            }
        }

        return true;
    }

    public bool IsMiddleElementUnique4(int[] nums)
    {
        var frequencies = new int[101];
        int middle = nums[nums.Length / 2];

        foreach (int num in nums)
        {
            if (num == middle && frequencies[num]++ == 1)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsMiddleElementUnique5(int[] nums)
    {
        int middle = nums[nums.Length / 2];
        bool seenMiddle = false;

        foreach (int num in nums)
        {
            if (num == middle)
            {
                if (seenMiddle)
                {
                    return false;
                }

                seenMiddle = true;
            }
        }

        return true;
    }
}
