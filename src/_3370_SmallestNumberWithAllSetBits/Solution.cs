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
    
    public int SmallestNumber2(int n)
    {
        int x = 1;

        while (x <= n)
        {
            x <<= 1;
        }

        return x - 1;
    }
}
