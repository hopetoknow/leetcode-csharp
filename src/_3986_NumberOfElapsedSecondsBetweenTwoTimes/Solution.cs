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

    public int SecondsBetweenTimes3(string startTime, string endTime)
    {
        return ToSeconds3(endTime) - ToSeconds3(startTime);
    }

    private int ToSeconds3(string time)
    {
        var p = time.Split(':').Select(int.Parse).ToArray();
        return p[0] * 3600 + p[1] * 60 + p[2];
    }
}
