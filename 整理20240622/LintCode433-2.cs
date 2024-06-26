using LeetCode.Template;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode433_2
    {
        private int _height;
        private int _width;
        public int NumIslands(bool[][] grid)
        {
            if (grid == null || grid.Length < 1 || grid[0].Length < 1)
            {
                return 0;
            }
            this._height = grid.Length;
            this._width = grid[0].Length;
            UnionFind uf = new UnionFind();
            for (int i = 0; i < this._height; i++)
            {
                for (int j = 0; j < this._width; j++)
                {
                    if (grid[i][j] == true)
                    {
                        uf.Add(GetId(i, j));
                    }
                }
            }
            int[] moveR = new int[] { 1, -1, 0, 0 };
            int[] moveC = new int[] { 0, 0, -1, 1 };
            for (int i = 0; i < this._height; i++)
            {
                for (int j = 0; j < this._width; j++)
                {
                    if (grid[i][j] == true)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            int nextR = i + moveR[k];
                            int nextC = j + moveC[k];
                            if (nextR >= 0 && nextR < this._height
                            && nextC >= 0 && nextC < this._width && grid[nextR][nextC] == true)
                            {
                                uf.Union(this.GetId(i, j), this.GetId(nextR, nextC));
                            }
                        }
                    }
                }
            }
            return uf.Count();
        }

        public int GetId(int r, int c)
        {
            return r * this._width + c;
        }
    }
}
