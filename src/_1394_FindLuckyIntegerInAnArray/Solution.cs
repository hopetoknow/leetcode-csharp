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
}
