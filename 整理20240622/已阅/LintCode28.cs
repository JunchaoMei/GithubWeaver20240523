using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode28
    {
        private int Row;
        private int Col;
        private int[][] Matrix;
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            this.Row = matrix.Length;
            this.Col = matrix[0].Length;
            this.Matrix = matrix;
            int left = 0;
            int right = this.Row * this.Col - 1;

            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                int val = GetValue(mid);
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
            if (GetValue(left) == target || GetValue(right) == target)
            {
                return true;
            }
            return false;
        }

        private int GetValue(int idx)
        {
            int col = idx % this.Col;
            int row = idx / this.Col;
            return this.Matrix[row][col];
        }
    }
}
