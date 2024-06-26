using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode39
    {
        private List<int> Nums;
        public void RecoverRotatedSortedArray(List<int> nums)
        {
            this.Nums = nums;
            int tail = this.FindTail();
            this.Reverse(0, tail);
            this.Reverse(tail + 1, nums.Count - 1);
            this.Reverse(0, nums.Count - 1);
        }

        private int FindTail()
        {
            int i = 0;
            while (i < this.Nums.Count - 1 && this.Nums[i] <= this.Nums[i + 1])
            {
                i++;
            }
            return i;
        }
        private void Reverse(int start, int end)
        {
            while (start < end)
            {
                int temp = this.Nums[start];
                this.Nums[start] = this.Nums[end];
                this.Nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
