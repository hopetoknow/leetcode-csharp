using System.Text;

namespace _3726_RemoveZerosInDecimalRepresentation;

public class Solution
{
    public long RemoveZeros(long n)
    {
        var sb = new StringBuilder();

        foreach (char c in n.ToString())
        {
            if (c != '0')
            {
                sb.Append(c);
            }
        }

        return long.Parse(sb.ToString());
    }
}