namespace _3330_FindTheOriginalTypedStringI;

public class Solution
{
    public int PossibleStringCount(string word)
    {
        int count = 1;

        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                count++;
            }
        }

        return count;
    }

    public int PossibleStringCount2(string word)
    {
        int n = word.Length;
        int count = n;

        for (int i = 1; i < n; i++)
        {
            if (word[i] != word[i - 1])
            {
                count--;
            }
        }

        return count;
    }

    public int PossibleStringCount3(string word)
    {
        return 1 + Enumerable.Range(1, word.Length - 1)
            .Count(i => word[i] == word[i - 1]);
    }

    public int PossibleStringCount4(string word)
    {
        return 1 + word.Zip(word.Skip(1), (a, b) => a == b ? 1 : 0).Sum();
    }
}