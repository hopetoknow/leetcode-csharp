namespace _1356_SortIntegersByTheNumberOf1Bits;

public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        return arr
            .OrderBy(CountBits)
            .ThenBy(n => n)
            .ToArray();
    }

    private int CountBits(int n)
    {
        int count = 0;

        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }
}
