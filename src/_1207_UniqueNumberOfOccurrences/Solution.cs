namespace _1207_UniqueNumberOfOccurrences;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var frequencyByNumber = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            frequencyByNumber[num] = frequencyByNumber.GetValueOrDefault(num) + 1;
        }

        return new HashSet<int>(frequencyByNumber.Values).Count == frequencyByNumber.Values.Count;
    }

    public bool UniqueOccurrences2(int[] arr)
    {
        var frequencies = arr.GroupBy(x => x).Select(g => g.Count()).ToList();
        return frequencies.Distinct().Count() == frequencies.Count;
    }
}