using System;

namespace Combinations
{
    public static class Calculator
    {
        public static Int32 Factorial(int n)
        {
            return n > 1 ? n*Factorial(n - 1) : n;
        }
    }
}