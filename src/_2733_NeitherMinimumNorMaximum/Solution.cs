namespace _2733_NeitherMinimumNorMaximum;

public class Solution
{
    public int FindNonMinOrMax(int[] nums)
    {
        int n = nums.Length;

        if (n <= 2)
        {
            return -1;
        }

        Array.Sort(nums);
        return nums[n / 2];
    }
    
    public int FindNonMinOrMax2(int[] nums)
    {
        int n = nums.Length;

        if (n <= 2)
        {
            return -1;
        }

        int min = 101;
        int max = 0;

        foreach (int num in nums)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }

        foreach (int num in nums)
        {
            if (num != max && num != min)
            {
                return num;
            }
        }

        return -1;
    }
    
    public int FindNonMinOrMax3(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return -1;
        }
        
        int min = nums.Min();
        int max = nums.Max();
        
        return nums.First(n => n != min && n != max);
    }
    
    public int FindNonMinOrMax4(int[] nums)
    {
        int n = nums.Length;

        if (n <= 2)
        {
            return -1;
        }

        int[] first3 = nums[..3];
        Array.Sort(first3);
        
        return first3[1];
    }
    
}
