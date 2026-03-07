using System.Text.RegularExpressions;

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

        return s[..(i + 1)];
        // return s.Substring(0, i + 1);
    }
    
    public string TrimTrailingVowels3(string s) => s.TrimEnd('a', 'e', 'i', 'o', 'u');
    
    public string TrimTrailingVowels4(string s)
    {
        ReadOnlySpan<char> span = s.AsSpan();

        while (span.Length > 0 && "aeiou".Contains(span[^1]))
        {
            span = span[..^1];
        }
            
        return span.ToString();
    }
    
    public string TrimTrailingVowels5(string s) => Regex.Replace(s, "[aeiou]+$", "");
}
