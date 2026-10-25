namespace _0509_FibonacciNumber;

public class Solution
{
    public int Fib(int n)
    {
        if (n < 2)
        {
            return n;
        }

        return Fib(n - 2) + Fib(n - 1);
    }

    public int Fib2(int n)
    {
        if (n < 2)
        {
            return n;
        }

        int prev = 0, curr = 1;

        for (int i = 2; i <= n; i++)
        {
            int next = prev + curr;
            prev = curr;
            curr = next;
        }

        return curr;
    }
}
