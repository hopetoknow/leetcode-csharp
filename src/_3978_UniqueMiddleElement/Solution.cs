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
}
