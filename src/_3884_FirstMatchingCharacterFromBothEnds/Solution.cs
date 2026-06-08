namespace _3884_FirstMatchingCharacterFromBothEnds;

public class Solution
{
    public int FirstMatchingIndex(string s)
    {
        int n = s.Length;

        for (int i = 0; i < (n + 1) / 2; i++)
        {
            if (s[i] == s[n - i - 1])
            {
                return i;
            }
        }

        return -1;
    }

    public int FirstMatchingIndex2(string s)
    {
        int n = s.Length;

        return Enumerable.Range(0, (n + 1) / 2)
            .Select(i => (int?)i)
            .FirstOrDefault(i => s[i!.Value] == s[n - i.Value - 1]) ?? -1;
    }
}