using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FactorialProblem
    {
        // ------------------------- Factorial Problem => Recursive Way ------------------------------------
        public static int factorial2(int number)
        {
            if (number <= 2)
            {
                return 2;
            }

            return number * factorial2(number - 1);

        }

        // ------------------------- Factorial Problem => Itrative Way ------------------------------------

        public static int factorial(int num)
        {
            int answare = 1;
            if (answare == 2)
            {
                answare = 2;
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    answare = answare * i;
                    //answare *= i;
                }
            }

            return answare;
        }
    }
}
