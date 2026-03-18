namespace _1374_GenerateAStringWithCharactersThatHaveOddCounts;

public class Solution
{
    public string GenerateTheString(int n)
    {
        if (n % 2 == 1)
        {
            return new string('a', n);
        }

        return new string('a', n - 1) + "b";
    }

    public string GenerateTheString2(int n) => n % 2 == 1 ? new string('a', n) : new string('a', n - 1) + 'b';
}