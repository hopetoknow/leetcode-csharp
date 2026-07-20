namespace _3986_NumberOfElapsedSecondsBetweenTwoTimes;

public class Solution
{
    public int SecondsBetweenTimes(string startTime, string endTime)
    {
        return ToSeconds(endTime) - ToSeconds(startTime);
    }

    private int ToSeconds(string time)
    {
        int h = int.Parse(time.Substring(0, 2));
        int m = int.Parse(time.Substring(3, 2));
        int s = int.Parse(time.Substring(6, 2));

        return h * 3600 + m * 60 + s;
    }

    public int SecondsBetweenTimes2(string startTime, string endTime)
    {
        TimeSpan start = TimeSpan.Parse(startTime);
        TimeSpan end = TimeSpan.Parse(endTime);

        return (int)(end - start).TotalSeconds;
    }
}
