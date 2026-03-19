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

    public string GenerateTheString3(int n) => new string('a', n - 1) + (n % 2 == 1 ? "a" : "b");

    public string GenerateTheString4(int n)
    {
        var chars = new char[n];
        Array.Fill(chars, 'a');

        if (n % 2 == 0)
        {
            chars[n - 1] = 'b';
        }


        return new string(chars);
    }
}