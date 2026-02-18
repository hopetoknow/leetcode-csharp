namespace _1470_ShuffleTheArray;

public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var ans = new int[2 * n];

        for (int i = 0, j = 0; i < 2 * n; i += 2, j++) 
        {
            ans[i] = nums[j];
            ans[i + 1] = nums[j + n];
        }

        return ans; 
    }
    
    public int[] Shuffle2(int[] nums, int n)
    {
        var ans = new int[2 * n];

        for (var i = 0; i < n; i++) 
        {
            ans[2 * i] = nums[i];
            ans[2 * i + 1] = nums[i + n];
        }

        return ans; 
    }
}
