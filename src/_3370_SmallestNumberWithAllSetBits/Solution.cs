namespace _3370_SmallestNumberWithAllSetBits;

public class Solution
{
    public int SmallestNumber(int n)
    {
        int exponent = 1;
        int x = 1;

        while (n >= x)
        {
            x = (int)Math.Pow(2, exponent++);
        }

        return x - 1;
    }
}
