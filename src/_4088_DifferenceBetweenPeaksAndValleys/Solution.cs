namespace _4088_DifferenceBetweenPeaksAndValleys;

public class Solution
{
    public int PeakValleyDifference(int[] nums)
    {
        int peakSum = 0, valleySum = 0;

        for (var i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                peakSum += nums[i];
            }
            else if (nums[i] < nums[i - 1] && nums[i] < nums[i + 1])
            {
                valleySum += nums[i];
            }
        }

        return peakSum - valleySum;
    }

    public int PeakValleyDifference2(int[] nums)
    {
        return Enumerable.Range(1, nums.Length - 2)
            .Sum(i =>
                nums[i] > nums[i - 1] && nums[i] > nums[i + 1] ? nums[i] :
                nums[i] < nums[i - 1] && nums[i] < nums[i + 1] ? -nums[i] :
                0
            );
    }
}
