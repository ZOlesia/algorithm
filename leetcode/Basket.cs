using System.Collections.Generic;

namespace leetcode
{
    public class Basket
    {
        public int TotalFruit(int[] tree) {
            var total = 0;
            
            var max = 1;
            
            if(tree.Length == 1) return max;
            
            var basket = new List<int>();
            basket.Add(tree[0]);
            
            var idx = 0;
            
            for(int i = 1; i < tree.Length; i++){
                if(tree[i] != tree[i-1]){
                    if(basket.Count == 2 && !basket.Contains(tree[i])){
                        basket.RemoveAll(x => x != tree[i-1]);
                        basket.Add(tree[i]);
                        max = i - idx;
                    } else if(basket.Count < 2){
                        basket.Add(tree[i]);
                    } 
                    idx = i;
                } 
                
                max++;
                
                if(total < max) total = max;
            }
            
            return total;
        }
    }
}