using System.Collections.Specialized;
using System.Text.Json.Serialization;

namespace FibbonacciArray
{
    public class Class1
    {
        private readonly int cont;

        int Fib(int n)
        {
            if (n <= 1)
                return n;
            return Fib(n-2) + Fib(n-1);
        }
        object Main()
        {
            int n = 25, i;
            for (i = 0; i < n; i++)
                Fib(n);
            return 0;
        }
    }
}