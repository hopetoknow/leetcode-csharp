namespace _1863_SumOfAllSubsetXORTotals;

public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int sum = 0;
        int n = nums.Length;

        List<bool[]> subsets = [];
        MakeSubsets(new bool[n], 0, subsets);

        foreach (bool[] subset in subsets)
        {
            int XORTotal = 0;

            for (int i = 0; i < n; i++)
            {
                if (subset[i])
                {
                    XORTotal ^= nums[i];
                }
            }

            sum += XORTotal;
        }

        return sum;
    }

    private void MakeSubsets(bool[] subset, int position, List<bool[]> subsets)
    {
        if (position == subset.Length)
        {
            subsets.Add(subset.ToArray());
            return;
        }

        subset[position] = false;
        MakeSubsets(subset, position + 1, subsets);
        subset[position] = true;
        MakeSubsets(subset, position + 1, subsets);
    }
}