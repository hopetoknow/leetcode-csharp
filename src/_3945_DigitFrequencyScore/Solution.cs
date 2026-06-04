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

        return score;
    }

    public int DigitFrequencyScore2(int n) => n.ToString().Sum(c => c - '0');
}