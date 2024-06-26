using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode159
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int left = 0;
            int right = nums.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                // 中点与右点对比推算最小值位置
                if (nums[mid] > nums[right])
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return Math.Min(nums[left], nums[right]);
        }
    }
}
