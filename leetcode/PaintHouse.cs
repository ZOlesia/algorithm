namespace leetcode
{
    public class PaintHouse
    {
        public static int minCost(int[][] costs){
            if(costs == null || costs.Length == 0) return 0;

            // for(int i = 1; i < costs.Length; i++){
            //     costs[i][0] += Math.Min(costs[i-1][1], costs[i-1][2]);
            //     costs[i][1] += Math.Min(costs[i-1][0], costs[i-1][2]);
            //     costs[i][2] += Math.Min(costs[i-1][0], costs[i-1][1]);
            // }

            // return Math.Min(Math.Min(costs[costs.Length-1][0], costs[costs.Length-1][1]), costs[costs.Length-1][2]);
            var result = 0;
            var skip = int.MaxValue;
            for(int i = 0; i < costs.Length; i++){
                var min = int.MaxValue;
                
                for(int j = 0; j < costs[i].Length; j++){
                    if(j == skip) continue;
                    if(costs[i][j] < min){
                        min = costs[i][j];
                        skip = j;
                    }
                }
                result += min;
            }
            return result;
        }

        // static void Main(string[] args)
        // {
        //     var num = new int[][]
        //     {
        //         new int[] {17, 2, 17},
        //         new int[] {16, 16, 5},
        //         new int[] {14, 3, 19}
        //     };
        //     System.Console.WriteLine(minCost(num));
        // }
    }
}