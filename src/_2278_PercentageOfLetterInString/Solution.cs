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

        return (int)(100.0 / s.Length * count);
    }
}
