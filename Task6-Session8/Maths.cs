using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Session8
{
    class Maths
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static double Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }

            return (double)x / y;
        }
    }
}
