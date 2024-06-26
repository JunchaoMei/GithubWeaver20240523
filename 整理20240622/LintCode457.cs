using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode457
    {
        public int findPosition(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            int left = 0;
            int right = nums.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            if (nums[left] == target)
            {
                return left;
            }
            if (nums[right] == target)
            {
                return right;
            }
            return -1;
        }
    }
}
