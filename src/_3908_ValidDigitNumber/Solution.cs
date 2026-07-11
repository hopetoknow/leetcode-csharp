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

    public bool ValidDigit2(int n, int x)
    {
        if (n < 10)
        {
            return false;
        }

        bool containsX = false;

        while (n >= 10)
        {
            if (n % 10 == x)
            {
                containsX = true;
            }

            n /= 10;
        }

        return containsX && n != x;
    }

    public bool ValidDigit3(int n, int x)
    {
        bool containsX = false;

        while (n > 9)
        {
            containsX = containsX || n % 10 == x;
            n /= 10;
        }

        return containsX && n != x;
    }
}
