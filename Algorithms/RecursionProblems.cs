using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RecursionProblems
    {
        // ------------------------- Fibonacci with cache => Recursive Way ------------------------------------
        public static int Fibonacci(int n)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            keyValuePairs.Add(1, 0);
            keyValuePairs.Add(2, 1);
            return Fibonacci(n, keyValuePairs);
        }

        public static int Fibonacci(int n, Dictionary<int, int> keyValuePairs)
        {
            if (keyValuePairs.ContainsKey(n))
            {
                return keyValuePairs[n];
            }
            else
            {
                keyValuePairs.Add(n, Fibonacci(n - 1, keyValuePairs) + Fibonacci(n - 2, keyValuePairs));
                return keyValuePairs[n];
            }
        }
    }
}
