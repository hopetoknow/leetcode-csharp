namespace _0509_FibonacciNumber;

public class Solution
{
    private static readonly int[] FibonacciNumbers =
    [
        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181,
        6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040
    ];

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

    public int Fib3(int n) => FibonacciNumbers[n];
}
