using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    // redo
    internal class LintCode894
    {
        public void PancakeSort(int[] array)
        {
            // Write your code here
            // [6,11,10,12,7,23,20]
            // [20,6,11,10,12,7,23]
            // [5,3,4,2]
            // [2,4,3,5]
            // [4,2,3,5]
            // [3,2,4,5]
            int n = array.Length;
            for (int i = n - 1; i >= 1; i--)
            {
                int maxIdx = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (array[j] > array[maxIdx])
                    {
                        maxIdx = j;
                    }
                }
                this.Flip(array, maxIdx);
                this.Flip(array, i);
            }
        }

        private void Flip(int[] array, int num)
        {
            for (int i = 0; i < (num + 1) / 2; i++)
            {
                this.Swap(array, i, num - i);
            }
        }

        private void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
