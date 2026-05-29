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

    public int[] CountOppositeParity2(int[] nums)
    {
        int n = nums.Length;
        var parities = new int[n];

        for (int i = 0; i < n; i++)
        {
            parities[i] = nums[i] % 2;
        }

        var answer = new int[n];

        for (int i = 0; i < n - 1; i++)
        {
            int score = 0;

            for (int j = i + 1; j < n; j++)
            {
                if (parities[i] != parities[j])
                {
                    score++;
                }
            }

            answer[i] = score;
        }

        return answer;
    }

    public int[] CountOppositeParity3(int[] nums)
    {
        int n = nums.Length;
        int evenCount = 0;
        int oddCount = 0;
        var answer = new int[n];

        for (int i = n - 2; i >= 0; i--)
        {
            if (nums[i + 1] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }

            answer[i] = nums[i] % 2 == 0 ? oddCount : evenCount;
        }

        return answer;
    }
}