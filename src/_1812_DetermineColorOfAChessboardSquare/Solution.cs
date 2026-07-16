namespace _1812_DetermineColorOfAChessboardSquare;

public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        return (coordinates[0] + coordinates[1]) % 2 != 0;
    }

    public bool SquareIsWhite2(string coordinates)
    {
        int column = coordinates[0] - 'a';
        int row = coordinates[1] - '1';

        return (column % 2) != (row % 2);
    }
}
