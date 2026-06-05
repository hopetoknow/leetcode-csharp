namespace _3945_DigitFrequencyScore;

public class Solution
{
    public int DigitFrequencyScore(int n)
    {
        int score = 0;

        while (n > 0)
        {
            score += n % 10;
            n /= 10;
        }

        // while (n > 0)
        // {
        //     (n, int rem) = Math.DivRem(n, 10);
        //     score += rem;
        // }

        return score;
    }

    public int DigitFrequencyScore2(int n) => n.ToString().Sum(c => c - '0');
}