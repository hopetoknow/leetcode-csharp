namespace _3959_CheckGoodInteger;

public class Solution
{
    public bool CheckGoodInteger(int n)
    {
        int digitSum = 0, squareSum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            digitSum += digit;
            squareSum += digit * digit;
            n /= 10;
        }

        return squareSum - digitSum >= 50;
    }

    public bool CheckGoodInteger2(int n)
    {
        int digitSum = 0, squareSum = 0;

        foreach (char c in n.ToString())
        {
            int digit = c - '0';
            digitSum += digit;
            squareSum += digit * digit;
        }

        return squareSum - digitSum >= 50;
    }

    public bool CheckGoodInteger3(int n)
    {
        var digits = n.ToString().Select(c => c - '0');

        return digits.Sum(d => d * d) - digits.Sum(d => d) >= 50;
    }
}