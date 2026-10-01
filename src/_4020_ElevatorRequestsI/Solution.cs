namespace _4020_ElevatorRequestsI;

public class Solution
{
    public int ElevatorRequests(int n, int[] requests)
    {
        int total = requests[0];

        for (int i = 1; i < requests.Length; i++)
        {
            total += Math.Abs(requests[i] - requests[i - 1]);
        }

        return total;
    }
}
