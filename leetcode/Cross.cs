using System.Collections.Generic;

namespace leetcode
{
    public class Cross
    {
        public static bool canCross(int[] stones){
            for(int i = 3; i < stones.Length; i++){
                if(stones[i] > stones[i-1]*2){
                    return false;
                }
            }

            var stonePositions = new HashSet<int>(stones);

            int lastStone = stones[stones.Length-1];
            var positions = new Stack<int>();
            var jumps = new Stack<int>();
            positions.Push(0);
            jumps.Push(0);
            while(positions.Count != 0){
                var position = positions.Pop();
                var jumpDistance = jumps.Pop();
                for(int i = jumpDistance-1; i <= jumpDistance+1; i++){
                    if(i<=0) continue;

                    var nextPosition = position + i;
                    if(nextPosition == lastStone) return true;
                    else if(stonePositions.Contains(nextPosition)){
                        positions.Push(nextPosition);
                        jumps.Push(i);
                    }
                }
            }
            return false;

        }
    }
}