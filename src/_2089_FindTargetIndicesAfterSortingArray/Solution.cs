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

    public IList<int> TargetIndices2(int[] nums, int target)
    {
        int less = 0, equal = 0;

        foreach (var num in nums)
        {
            if (num < target)
            {
                less++;
            }
            else if (num == target)
            {
                equal++;
            }
        }

        List<int> result = new(equal);

        for (var i = 0; i < equal; i++)
        {
            result.Add(less + i);
        }

        return result;
    }

    public IList<int> TargetIndices3(int[] nums, int target)
    {
        int less = nums.Count(num => num < target);
        int equal = nums.Count(num => num < target);

        return Enumerable.Range(less, equal).ToList();
    }
}
