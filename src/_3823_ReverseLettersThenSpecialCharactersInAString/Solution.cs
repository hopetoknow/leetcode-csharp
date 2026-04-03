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
}
