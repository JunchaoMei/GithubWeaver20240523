using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // 这个过了但是时间复杂度可能不够。。。
    internal class LintCode460_1
    {
        private int Target;
        public int[] KClosestNumbers(int[] a, int target, int k)
        {
            this.Target = target;
            int[] diff = a.ToList().OrderBy(v => this.GetDist(v)).ToArray();
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = diff[i];
            }
            return res;
        }

        private int GetDist(int val)
        {
            return Math.Abs(val - this.Target);
        }
    }
}
