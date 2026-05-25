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

    public int[] FindThePrefixCommonArray2(int[] A, int[] B)
    {
        int n = A.Length;
        var frequencyByNumber = new Dictionary<int, int>();
        int commonCount = 0;
        var prefixCommonArray = new int[n];

        for (var i = 0; i < n; i++)
        {
            frequencyByNumber[A[i]] = frequencyByNumber.GetValueOrDefault(A[i]) + 1;

            if (frequencyByNumber[A[i]] == 2)
            {
                commonCount++;
            }

            frequencyByNumber[B[i]] = frequencyByNumber.GetValueOrDefault(B[i]) + 1;

            if (frequencyByNumber[B[i]] == 2)
            {
                commonCount++;
            }

            prefixCommonArray[i] = commonCount;
        }

        return prefixCommonArray;
    }

    public int[] FindThePrefixCommonArray3(int[] A, int[] B)
    {
        int n = A.Length;
        var frequencies = new int[n + 1];
        int commonCount = 0;
        var prefixCommonArray = new int[n];

        for (var i = 0; i < n; i++)
        {
            if (++frequencies[A[i]] == 2)
            {
                commonCount++;
            }

            if (++frequencies[B[i]] == 2)
            {
                commonCount++;
            }

            prefixCommonArray[i] = commonCount;
        }

        return prefixCommonArray;
    }

    public int[] FindThePrefixCommonArray4(int[] A, int[] B)
    {
        int n = A.Length;
        var seenA = new HashSet<int>();
        var seenB = new HashSet<int>();
        var prefixCommonArray = new int[n];

        for (var i = 0; i < n; i++)
        {
            seenA.Add(A[i]);
            seenB.Add(B[i]);

            int commonCount = 0;

            foreach (int num in seenA)
            {
                if (seenB.Contains(num))
                {
                    commonCount++;
                }
            }

            prefixCommonArray[i] = commonCount;
        }

        return prefixCommonArray;
    }

    public int[] FindThePrefixCommonArray5(int[] A, int[] B)
    {
        int n = A.Length;
        var seenA = new HashSet<int>();
        var seenB = new HashSet<int>();
        int commonCount = 0;
        var prefixCommonArray = new int[n];

        for (var i = 0; i < n; i++)
        {
            seenA.Add(A[i]);

            if (seenB.Contains(A[i]))
            {
                commonCount++;
            }

            seenB.Add(B[i]);

            if (seenA.Contains(B[i]))
            {
                commonCount++;
            }

            prefixCommonArray[i] = commonCount;
        }

        return prefixCommonArray;
    }
}