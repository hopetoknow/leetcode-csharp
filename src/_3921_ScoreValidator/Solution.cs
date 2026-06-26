namespace _3921_ScoreValidator;

public class Solution
{
    public int[] ScoreValidator(string[] events)
    {
        int score = 0, counter = 0;

        foreach (string e in events)
        {
            if (counter == 10)
            {
                break;
            }

            if (e == "W")
            {
                counter++;
            }
            else if (e is "WD" or "NB")
            {
                score++;
            }
            else
            {
                score += int.Parse(e);
            }
        }

        return [score, counter];
    }
}