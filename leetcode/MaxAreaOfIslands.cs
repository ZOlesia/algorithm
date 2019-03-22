using System;

namespace leetcode
{
    public class MaxAreaOfIslands
    {
        public static int maxArea(int[][] grid){
            var max = 0;

            for(int i = 0; i < grid.Length; i++){
                for(int j = 0; j < grid[i].Length; j++){
                    if(grid[i][j] == 1){
                        max = Math.Max(max, dfs(grid, i, j));
                    }
                }
            }

            return max;
        }

        private static int dfs(int[][] grid, int i, int j)
        {
            if(i >= grid.Length || i < 0 || j >= grid[i].Length || j < 0 || grid[i][j] == 0){
                return 0;
            }

            grid[i][j] = 0;
            var count = 1;
            count += dfs(grid, i+1, j);
            count += dfs(grid, i-1, j);
            count += dfs(grid, i, j+1);
            count += dfs(grid, i, j-1);

            return count;
        }
    }
}