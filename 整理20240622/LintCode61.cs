using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode61
    {
        private int Target;
        private int[] A;
        public int[] SearchRange(int[] a, int target)
        {
            this.Target = target;
            this.A = a;
            if (a.Length == 0)
            {
                return new int[] { -1, -1 };
            }
            int start = this.BinarySearchFirst();
            int end = this.BinarySearchLast();
            return new int[] { start, end };
        }

        private int BinarySearchLast()
        {
            int left = 0;
            int right = this.A.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (this.A[mid] <= this.Target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            if (this.A[right] == this.Target)
            {
                return right;
            }
            if (this.A[left] == this.Target)
            {
                return left;
            }
            return -1;
        }

        private int BinarySearchFirst()
        {
            int left = 0;
            int right = this.A.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (this.A[mid] >= this.Target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            if (this.A[left] == this.Target)
            {
                return left;
            }
            if (this.A[right] == this.Target)
            {
                return right;
            }
            return -1;
        }
    }
}
