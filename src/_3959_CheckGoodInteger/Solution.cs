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
}