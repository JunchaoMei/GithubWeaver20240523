using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode38
    {
        // 这道题虽然过了，但是总感觉不是最好的方法，没什么思路
        private int Row;
        private int Col;
        private int[][] Matrix;
        public int SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return 0;
            }
            this.Row = matrix.Length;
            this.Col = matrix[0].Length;
            this.Matrix = matrix;
            int res = 0;
            for (int i = 0; i < this.Row; i++)
            {
                if (matrix[i][0] > target || matrix[i][this.Col - 1] < target)
                {
                    continue;
                }
                if (this.HasTarget(target, i))
                {
                    res++;
                }
            }
            return res;
        }

        private bool HasTarget(int target, int row)
        {
            int left = 0;
            int right = this.Matrix[row].Length - 1;

            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                int val = this.Matrix[row][mid];
                if (val == target)
                {
                    return true;
                }
                else if (val > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            if (this.Matrix[row][left] == target || this.Matrix[row][right] == target)
            {
                return true;
            }
            return false;
        }
    }
}
