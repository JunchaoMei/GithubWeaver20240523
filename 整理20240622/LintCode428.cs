using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode428
    {
        public double myPow(double x, int n)
        {
            long l = n;
            return this.Helper(x, l);
        }

        private double Helper(double x, long n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                n *= -1;
                x = 1 / x;
            }
            double val = this.Helper(x, n / 2);
            double res = val * val;
            if (n % 2 == 1)
            {
                res *= x;
            }
            return res;
        }
    }
}
