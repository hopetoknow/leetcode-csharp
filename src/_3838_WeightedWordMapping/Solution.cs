using System.Text;

namespace _3838_WeightedWordMapping;

public class Solution
{
    public string MapWordWeights(string[] words, int[] weights)
    {
        var ans = new StringBuilder();

        foreach (string word in words)
        {
            var wordWeight = 0;

            foreach (char ch in word)
            {
                wordWeight += weights[ch - 'a'];
            }

            ans.Append((char)('z' - wordWeight % 26));
        }

        return ans.ToString();
    }
}
