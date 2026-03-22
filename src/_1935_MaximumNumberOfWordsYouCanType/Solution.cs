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
    
    public int CanBeTypedWords2(string text, string brokenLetters)
    {
        var brokenLettersSet = new HashSet<char>(brokenLetters);
        return text.Split(' ').Count(word => !word.Any(letter => brokenLettersSet.Contains(letter)));
        
        //return text.Split(' ').Count(word => !word.Any(letter => brokenLetters.Contains(letter)));
    }
}