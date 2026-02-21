namespace _0693_BinaryNumberWithAlternatingBits;

public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        var bits = new List<int>();

        while (n > 0)
        {
            bits.Add(n % 2);
            n /= 2;
        }

        for (var i = 1; i < bits.Count; i++)
        {
            if (bits[i] == bits[i - 1])
            {
                return false;
            }
        }

        return true;
    }
    
    public bool HasAlternatingBits2(int n)
    {
        string binary = Convert.ToString(n, 2);

        for (int i = 1; i < binary.Length; i++)
        {
            if (binary[i] == binary[i - 1])
            {
                return false;
            }
        }

        return true;
    }
}
