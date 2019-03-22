using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public class KeysAndrooms
    {
        public static bool CanVisitAllRooms(List<List<int>> rooms){
            var visited = new HashSet<int>();
            visited.Add(0);
            var stack = new Stack<int>();
            stack.Push(0);

            while(stack.Count != 0){
                List<int> keys = rooms.ElementAt(stack.Pop());

                foreach(var key in keys){
                    if(!visited.Contains(key)){
                        visited.Add(key);
                        stack.Push(key);
                    }
                }
            }

            return rooms.Count == visited.Count;
        }
    }
}