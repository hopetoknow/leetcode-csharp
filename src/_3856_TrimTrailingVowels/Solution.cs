namespace _3856_TrimTrailingVowels;

public class Solution
{
    public string TrimTrailingVowels(string s) 
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        var chars = s.ToList();

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (vowels.Contains(chars[i]))
            {
                chars.RemoveAt(i);
            }
            else
            {
                break;
            }
        }

        return new string(chars.ToArray());;
    }
    
    public string TrimTrailingVowels2(string s)
    {
        var i = s.Length - 1;

        while (i >= 0 && "aeiou".Contains(s[i]))
        {
            i--;
        }

        return s.Substring(0, i + 1);
    }
}
