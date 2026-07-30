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
}
