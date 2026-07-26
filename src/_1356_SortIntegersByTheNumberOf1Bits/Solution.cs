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

    public int[] SortByBits2(int[] arr)
    {
        Array.Sort(arr, (a, b) =>
        {
            int bitsA = CountBits(a);
            int bitsB = CountBits(b);

            if (bitsA != bitsB)
            {
                return bitsA - bitsB;
            }

            return a - b;
        });

        return arr;
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

    public int[] SortByBits3(int[] arr)
    {
        return arr
            .OrderBy(CountBitsKernighan)
            .ThenBy(n => n)
            .ToArray();
    }

    private int CountBitsKernighan(int n)
    {
        int count = 0;

        while (n != 0)
        {
            n &= n - 1;
            count++;
        }

        return count;
    }
}
