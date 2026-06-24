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

    public bool IsAdjacentDiffAtMostTwo2(string s)
    {
        return Enumerable.Range(0, s.Length - 1).All(i => Math.Abs(s[i] - s[i + 1]) <= 2);
    }

    public bool IsAdjacentDiffAtMostTwo3(string s)
    {
        return s.Zip(s.Skip(1)).All(p => Math.Abs(p.First - p.Second) <= 2);
    }
}