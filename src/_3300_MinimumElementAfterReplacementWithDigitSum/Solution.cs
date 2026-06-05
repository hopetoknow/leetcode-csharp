namespace _3300_MinimumElementAfterReplacementWithDigitSum;

public class Solution
{
    public int MinElement(int[] nums)
    {
        var min = int.MaxValue;

        foreach (int num in nums)
        {
            int digitSum = 0;
            int n = num;

            while (n > 0)
            {
                digitSum += n % 10;
                n /= 10;
            }

            // while (n > 0)
            // {                
            //     (n, int rem) = Math.DivRem(n, 10);
            //     digitSum += rem;
            // }

            min = int.Min(min, digitSum);
        }

        return min;
    }

    public int MinElement2(int[] nums) => nums.Select(num => num.ToString().Sum(c => c - '0')).Min();

    public int MinElement3(int[] nums) => nums.Min(num => num.ToString().Sum(c => c - '0'));
}