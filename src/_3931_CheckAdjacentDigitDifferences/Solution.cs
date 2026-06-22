namespace _3931_CheckAdjacentDigitDifferences;

public class Solution
{
    public bool IsAdjacentDiffAtMostTwo(string s)
    {        
        for (var i = 1; i < s.Length; i++)
        {
            if (Math.Abs(s[i] - s[i - 1]) > 2)
            {
                return false;
            }
        }

        return true;
    }
}
