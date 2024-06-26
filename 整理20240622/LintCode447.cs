using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // converted from java, has to be commented out
    internal class LintCode447
    {
        //public int searchBigSortedArray(ArrayReader reader, int target)
        //{
        //    int left = 0;
        //    int right = 1;
        //在不知道数列大小的情况下，探索二叉搜索的上限
        //    while (reader.get(right - 1) < target)
        //    {
        //        right *= 2;
        //    }

        //    while (left + 1 < right)
        //    {
        //        int mid = left + (right - left) / 2;
        //        if (reader.get(mid) >= target)
        //        {
        //            right = mid;
        //        }
        //        else
        //        {
        //            left = mid;
        //        }
        //    }
        //    if (reader.get(left) == target)
        //    {
        //        return left;
        //    }
        //    if (reader.get(right) == target)
        //    {
        //        return right;
        //    }
        //    return -1;
        //}
    }
}
