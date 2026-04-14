namespace _2651_CalculateDelayedArrivalTime;

public class Solution
{
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
    {
        return (arrivalTime + delayedTime) % 24;
    }
}
