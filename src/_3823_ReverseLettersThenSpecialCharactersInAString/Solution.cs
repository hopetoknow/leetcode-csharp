using System.Text;

namespace _3823_ReverseLettersThenSpecialCharactersInAString;

public class Solution
{
    public string ReverseByType(string s)
    {
        var chars = s.ToCharArray();

        Reverse(chars, char.IsLetter);
        Reverse(chars, ch => !char.IsLetter(ch));

        return new string(chars);
    }

    private void Reverse(char[] chars, Func<char, bool> predicate)
    {
        for (int i = 0, j = chars.Length - 1; i < j;)
        {
            if (!predicate(chars[i]))
            {
                i++;
                continue;
            }
                
            if (!predicate(chars[j]))
            { 
                j--;
                continue; 
            }
            
            (chars[i], chars[j]) = (chars[j], chars[i]);
            i++;
            j--;
        }
    }
    
    public string ReverseByType2(string s)
    {
        var letters = new StringBuilder();
        var nonLetters = new StringBuilder();
        var chars = s.ToCharArray();

        foreach (char ch in chars)
        {
            if (char.IsLetter(ch))
            {
                letters.Append(ch);
            }
            else
            {
                nonLetters.Append(ch);
            }
        }

        int j = letters.Length, k = nonLetters.Length;

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetter(chars[i]))
            {
                chars[i] = letters[--j];
            }
            else
            {
                chars[i] = nonLetters[--k];
            }
        }

        return new string(chars);
    }
}
