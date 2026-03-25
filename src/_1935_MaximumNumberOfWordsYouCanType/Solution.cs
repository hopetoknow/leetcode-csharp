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
    
    public int CanBeTypedWords3(string text, string brokenLetters)
    {
        return text.Split(' ').Count(word => !word.Intersect(brokenLetters).Any());
    }
    
    public int CanBeTypedWords4(string text, string brokenLetters)
    {
        var brokenLettersArr = new bool[26];

        foreach (char c in brokenLetters)
        {
            brokenLettersArr[c - 'a'] = true;
        }

        int count = 0;
        
        foreach (var word in text.Split(' '))
        {
            bool typeable = true;
            
            foreach (char c in word)
            {
                if (brokenLettersArr[c - 'a'])
                {
                    typeable = false; 
                    break;
                }
            }

            if (typeable)
            {
                count++;
            } 
        }
        
        return count;
    }
    
    public int CanBeTypedWords5(string text, string brokenLetters)
    {
        var brokenLettersArr = new bool[26];

        foreach (char c in brokenLetters)
        {
            brokenLettersArr[c - 'a'] = true;
        }

        int count = 0;
        
        foreach (var word in text.Split(' '))
        {
            foreach (char c in word)
            {
                if (brokenLettersArr[c - 'a'])
                {
                    count--; 
                    break;
                }
            }
            
            count++;
        }
        
        return count;
    }
}
