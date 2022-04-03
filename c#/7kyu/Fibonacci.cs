// Create function fib that returns n'th element of Fibonacci sequence (classic programming task).



public class Fibonacci
{
    public static int fib(int n)
    {
                if (n == 1)
                    return 1;
                if(n==0)
                    return 0;
                else
                return fib(n-2) + fib(n-1);
    }
}