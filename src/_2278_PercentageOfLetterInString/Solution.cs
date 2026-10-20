namespace _2278_PercentageOfLetterInString;

public class Solution
{
    public int PercentageLetter(string s, char letter)
    {
        int count = 0;

        foreach (char c in s)
        {
            if (c == letter)
            {
                count++;
            }
        }

        return count * 100 / s.Length;
    }

    public int PercentageLetter2(string s, char letter)
    {
        return s.Count(c => c == letter) * 100 / s.Length;
    }
}
