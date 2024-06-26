using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    internal class LintCode433_1
    {
        private int _width;
        private int _height;
        private int _res;
        private bool[][] _grid;
        private Queue<int> _queue;
        private HashSet<int> _hashset;

        public int NumIslands(bool[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }
            this._height = grid.Length;
            this._width = grid[0].Length;
            this._res = 0;
            this._grid = grid;
            this._hashset = new HashSet<int>();
            this._queue = new Queue<int>();
            for (int i = 0; i < this._height; i++)
            {
                for (int j = 0; j < this._width; j++)
                {
                    this.BFS(i, j);
                }
            }
            return this._res;
        }

        private void BFS(int startR, int startC)
        {
            int startId = GetId(startR, startC);
            if (this._hashset.Contains(startId)
            || this._grid[startR][startC] == false)
            {
                return;
            }
            this._hashset.Add(startId);
            this._queue.Enqueue(startId);
            int[] moveR = new int[] { 1, -1, 0, 0 };
            int[] moveC = new int[] { 0, 0, -1, 1 };
            while (this._queue.Count > 0)
            {
                int size = this._queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int cur = this._queue.Dequeue();
                    int r = cur / this._width;
                    int c = cur % this._width;
                    for (int j = 0; j < 4; j++)
                    {
                        int nextR = r + moveR[j];
                        int nextC = c + moveC[j];
                        if (nextR >= 0 && nextR < this._height
                        && nextC >= 0 && nextC < this._width
                        && !this._hashset.Contains(GetId(nextR, nextC))
                        && this._grid[nextR][nextC] == true)
                        {
                            this._queue.Enqueue(GetId(nextR, nextC));
                            this._hashset.Add(GetId(nextR, nextC));
                        }
                    }
                }
            }
            this._res++;
        }

        private int GetId(int r, int c)
        {
            return r * this._width + c;
        }
    }
}
