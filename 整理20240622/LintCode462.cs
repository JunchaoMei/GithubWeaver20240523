using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode462
    {
        private int Target;
        private int[] A;
        public int TotalOccurrence(int[] a, int target)
        {
            this.Target = target;
            this.A = a;
            if (a.Length == 0)
            {
                return 0;
            }
            int start = this.BinarySearch(true);
            int end = this.BinarySearch(false);
            if (start == -1)
            {
                return 0;
            }
            return end - start + 1;
        }

        private int BinarySearch(bool first = true)
        {
            int left = 0;
            int right = this.A.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (first)
                {
                    if (this.A[mid] >= this.Target)
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid;
                    }
                }
                else
                {
                    if (this.A[mid] <= this.Target)
                    {
                        left = mid;
                    }
                    else
                    {
                        right = mid;
                    }
                }

            }
            if (first)
            {
                if (this.A[left] == this.Target)
                {
                    return left;
                }
                if (this.A[right] == this.Target)
                {
                    return right;
                }
            }
            else
            {
                if (this.A[right] == this.Target)
                {
                    return right;
                }
                if (this.A[left] == this.Target)
                {
                    return left;
                }
            }

            return -1;
        }
    }
}
