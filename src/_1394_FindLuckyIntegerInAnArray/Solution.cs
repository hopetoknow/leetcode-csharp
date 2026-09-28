namespace _1394_FindLuckyIntegerInAnArray;

public class Solution
{
    public int FindLucky(int[] arr)
    {
        var frequencyByNumber = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num, 0) + 1;
        }

        var luckies = new List<int>();

        foreach (KeyValuePair<int, int> pair in frequencyByNumber)
        {
            if (pair.Key == pair.Value)
            {
                luckies.Add(pair.Key);
            }
        }

        return luckies.Count == 0 ? -1 : luckies.Max();
    }

    public int FindLucky2(int[] arr)
    {
        var frequencies = new int[501];

        foreach (int num in arr)
        {
            frequencies[num]++;
        }

        int maxLucky = -1;

        for (int i = 1; i < 501; i++)
        {
            if (i == frequencies[i] && i > maxLucky)
            {
                maxLucky = i;
            }
        }

        return maxLucky;
    }

    public int FindLucky3(int[] arr)
    {
        var frequencies = new int[501];

        foreach (int num in arr)
        {
            frequencies[num]++;
        }

        for (int i = 500; i >= 1; i--)
        {
            if (i == frequencies[i])
            {
                return i;
            }
        }

        return -1;
    }
}
