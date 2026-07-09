namespace _3908_ValidDigitNumber;

public class Solution
{
    public bool ValidDigit(int n, int x)
    {
        if (x == 0 && n == 0)
        {
            return false;
        }

        bool containsX = false;

        while (n > 0)
        {
            if (n % 10 == x)
            {
                containsX = true;
            }

            if (n < 10 && n == x)
            {
                return false;
            }

            n /= 10;
        }

        return containsX;
    }
}
