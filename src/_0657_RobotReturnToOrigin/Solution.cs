namespace _0657_RobotReturnToOrigin;

public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int x = 0, y = 0;

        foreach (char move in moves)
        {
            switch (move)
            {
                case 'R': x++; break;
                case 'L': x--; break;
                case 'U': y++; break;
                case 'D': y--; break;
            }
        }

        return x == 0 && y == 0;
    }

    public bool JudgeCircle2(string moves)
    {
        int[] counts = new int[128];

        foreach (char move in moves)
        {
            counts[move]++;
        }

        return counts['U'] == counts['D'] && counts['L'] == counts['R'];
    }

    public bool JudgeCircle3(string moves)
    {
        return moves.Count(c => c == 'U') == moves.Count(c => c == 'D')
               && moves.Count(c => c == 'L') == moves.Count(c => c == 'R');
    }
}
