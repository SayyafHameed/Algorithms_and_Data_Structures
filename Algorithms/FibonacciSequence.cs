using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FibonacciSequence
    {
        // ------------------------- Fibonacci sequence => Recursive Way ------------------------------------
        public static int Fibonacci(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }
            else
            {
                return (Fibonacci(x - 1) + Fibonacci(x - 2));
            }
        }
    }
}
