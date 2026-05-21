namespace _2657_FindThePrefixCommonArrayOfTwoArrays;

public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int n = A.Length;
        var frequencyByNumber = new Dictionary<int, int>();
        var prefixCommonArray = new int[n];

        for (var i = 0; i < n; i++)
        {
            frequencyByNumber[A[i]] = frequencyByNumber.GetValueOrDefault(A[i]) + 1;
            frequencyByNumber[B[i]] = frequencyByNumber.GetValueOrDefault(B[i]) + 1;

            int commonCount = 0;

            foreach (KeyValuePair<int, int> pair in frequencyByNumber)
            {
                if (pair.Value == 2)
                {
                    commonCount++;
                }
            }

            prefixCommonArray[i] = commonCount;
        }

        return prefixCommonArray;
    }
}