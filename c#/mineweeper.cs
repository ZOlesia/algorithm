using System;
using System.Collections.Generic;

namespace c_
{
    public class Mineweeper
    {

        public static int[,] mineW(int w, int h, int mines)
        {
            int[,] grid = new int[h, w];

            int[] row = new int[] {
                -1, -1, -1,
                0, 0, 0,
                1, 1, 1
            };

            int[] col = new int[] {
                -1, 0, 1,
                -1, 0, 1,
                -1, 0, 1
            };

            Random rnd = new Random();

            for(int i = 0; i < mines; i++)
            {
                var idx1 = rnd.Next(0, w); // you can do just with width or heught without 0 and it will still generate between 0 and n point
                var idx2 = rnd.Next(0, h);
                grid[idx2, idx1] = 9;
                for (int j = 0; j < row.Length; j++)
                {
                    if(idx2+row[j] >= 0 && idx1+col[j] >= 0 && idx2+row[j] < h && idx1+col[j] < w)
                    {
                        if(grid[idx2+row[j], idx1+col[j]] != 9)
                        {
                            grid[idx2+row[j], idx1+col[j]]++;
                        }
                    }
                }
            }
            return grid;
        }
    }
}