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

    public long RemoveZeros2(long n)
    {
        return long.Parse(n.ToString().Replace("0", ""));
    }

    public long RemoveZeros3(long n)
    {
        return long.Parse(n.ToString().Where(c => c != '0').ToArray());
    }
}
