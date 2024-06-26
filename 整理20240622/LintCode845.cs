using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode845
    {
        public int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return this.Gcd(b, a % b);
        }
    }
}
