using System.Collections.Generic;

namespace leetcode
{
    public class FindTheCelebrity
    {
        // public static int findCelebrity(int n){

        //     int candidate = 0;

        //     for(int i = 1; i < n; i++){
        //         if(knows(candidate, i)){
        //             candidate = i;
        //         }
        //     }

        //     for(int i = 0; i < n; i++){
        //         if(i != candidate && knows(candidate, i) || !knows(i, candidate)){
        //             return -1;
        //         }
        //     }

        //     return candidate;
        // }

        // public static int findCelebrityWithStack(int n){
        //     var stack = new Stack<int>();

        //     int c = 0;

        //     for(int i = 0; i < n; i++){
        //         stack.Push(i);
        //     }

        //     while(stack.Count > 1){
        //         var current = stack.Pop();
        //         if(!knows(current, stack.Peek())){
        //             stack.Pop();
        //             stack.Push(current);
        //             c = current;
        //         } 
        //     }

        //     for(int i = 0; i < n; i++){
        //         if(i != c && knows(c, i) || !knows(i, c)){
        //             return -1;
        //         }
        //     }

        //     return c;
        // }
    }
}