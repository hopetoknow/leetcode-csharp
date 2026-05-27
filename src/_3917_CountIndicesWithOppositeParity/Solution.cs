namespace _3917_CountIndicesWithOppositeParity;

public class Solution
{
    public int[] CountOppositeParity(int[] nums)
    {
        int n = nums.Length;
        var answer = new int[n];

        for (var i = 0; i < n - 1; i++)
        {
            int iParity = nums[i] & 1;
            int score = 0;

            for (var j = i + 1; j < n; j++)
            {
                if (iParity != (nums[j] & 1))
                {
                    score++;
                }
            }

            answer[i] = score;
        }

        return answer;
    }
}