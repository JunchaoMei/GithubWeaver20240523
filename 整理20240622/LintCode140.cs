using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode140
    {
        public int FastPower(int a, int b, int n)
        {
            if (n == 0)
            {
                return 1 % b;
            }
            if (n == 1)
            {
                return a % b;
            }
            long val = this.FastPower(a, b, n / 2);
            long res = val * val % b;
            if (n % 2 == 1)
            {
                res = res * a % b;
            }
            return (int)res;
        }
    }
}
