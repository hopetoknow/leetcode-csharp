namespace _2089_FindTargetIndicesAfterSortingArray;

public class Solution
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);
        List<int> result = [];

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
