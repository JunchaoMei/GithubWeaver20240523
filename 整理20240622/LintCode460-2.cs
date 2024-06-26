using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo,倒是挺快，但是很丑。。。
    internal class LintCode460_2
    {
        private int Target;
        private int K;
        private int[] Nums;
        public int[] KClosestNumbers(int[] a, int target, int k)
        {
            if (a == null || a.Length == 0)
            {
                return a;
            }
            if (k > a.Length)
            {
                return a;
            }
            this.Target = target;
            this.K = k;
            this.Nums = a;
            int idx = this.FindTarget();
            int left = idx - 1;
            int right = idx;
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                if (left < 0)
                {
                    res[i] = a[right++];
                }
                else if (right >= a.Length)
                {
                    res[i] = a[left--];
                }
                else
                {
                    if (target - a[left] <= a[right] - target)
                    {
                        res[i] = a[left--];
                    }
                    else
                    {
                        res[i] = a[right++];
                    }
                }
            }
            return res;
        }

        private int FindTarget()
        {
            int left = 0;
            int right = this.Nums.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (this.Nums[mid] >= this.Target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            if (this.Nums[left] >= this.Target)
            {
                return left;
            }
            if (this.Nums[right] >= this.Target)
            {
                return right;
            }
            return this.Nums.Length;
        }
    }
}
