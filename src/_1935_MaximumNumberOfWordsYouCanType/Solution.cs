namespace _1935_MaximumNumberOfWordsYouCanType;

public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var words = text.Split(' ');        
        var brokenLettersSet = new HashSet<char>(brokenLetters);
        int ans = words.Length;

        foreach (string word in words)
        {
            foreach (char letter in word)
            {
                if (brokenLettersSet.Contains(letter))
                {
                    ans--;
                    break;
                }
            }
        }        

        return ans;
    }
}