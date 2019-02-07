using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LL
{
    class Program
    {
        // public class Node
        // {
        //     Node next = null;
        //     int data;
        //     public Node(int d){
        //         next = d;
        //     }
        // }

        // public static void RemoveDups(LinkedListNode n){
        //     LinkedListNode previous = null;
        //     var arr = new HashSet<int>();
        //     while(n != null){
        //         if(arr.Contains(n.data)){
        //             previous.next = n.next;
        //         }
        //         else{
        //             arr.Add(n.data);
        //             previous = n;
        //         }
        //         n = n.next;
        //     }
        // }

        // public static LinkedListNode NthToLast(LinkedListNode head, int k){
        //     var current = head;
        //     var follower = head;
        //     var count = 0;
        //     while(current.Next != null){
        //         if(count != k){
        //             count++;
        //         } else if(count == k){
        //             follower = follower.Next;
        //         }
        //         current = current.Next;
        //     }
        //     return follower;
        // }

        // public static bool DeleteMiddleNode(LinkedListNode node){
        //     if(node == null) return false;
        //     if(node.next == null){
        //         node = null;
        //         return true;
        //     }

        //     var nextNode = node.next;
        //     node.data = nextNode.data;
        //     node.next = nextNode.next;
        //     return true;

        // }

        // public static LinkedListNode Partition(LinkedListNode head, int p){
        //     var runner = head;
        //     var previous = null;
        //     while(runner != null){
        //         if(runner.Value < p){
        //             var holder = runner;
        //             previous.next = runner.next;
        //             holder.next = head.next;
        //             head.next = holder;
        //             runner = previous;
        //         }
        //         previous = runner;
        //         runner = runner.next;
        //     }
        //     return head;
        // // }
        // public static LinkedListNode SumLists(LinkedListNode head1, LinkedListNode head2){
        //     //get the longest length of the lists
        //     //I will assume head1 has the longest length
        //     var r1 = head1;
        //     var r2 = head2;
            
        //     while(r1!=null){
        //         var increaser = 0;
        //         var num2 = 0;
        //         if(r2 != null) num2 = r2.Value;

        //         var sum = r1.Value + num2;

        //         if(sum > 9){
        //             var splitNum = GetIntArray(sum);
        //             increaser = splitNum[1];
        //             r1.Next.Value += splitNum[1];
        //         }

        //         if(increaser == 0 && r2 == null) return r1;
        //         if(r2 != null) r2 = r2.Next;

        //         r1 = r1.Next;
        //     }
        //     return r1;
        // }
        // public static List<int> GetIntArray(int num)
        // {
        //     List<int> listOfInts = new List<int>();
        //     while(num > 0)
        //     {
        //         listOfInts.Add(num % 10);
        //         num = num / 10;
                
        //     }
        //     return listOfInts.Reverse();
        // }

        public static bool Palindrome(LinkedListNode head){
            var faster = head;
            var current = head;
            var isOdd = false;
            var arr = new List<int>();
            
            while(faster != null){

                if(faster.Next == null){
                    break;
                }

                arr.Add(current.Value);

                faster = faster.Next.Next;
                current = current.Next;
            }

            if(isOdd) current = current.Next;
            

            for(int i = arr.Count; i >= 0; i--){
                if(arr[i] != current.Value) return false;
                current = current.Next;
            }
            return true;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(5/2);
            // var num = 26;
            // GetIntArray(num);
            // Console.WriteLine("Hello World!");

            // var link = new LinkedList();

            // var node1 = new LinkedListNode(5);
            // var node2 = new LinkedListNode<int>(2);
            // var node3 = new LinkedListNode<int>(16);
            // var node4 = new LinkedListNode<int>(75);
            // var node5 = new LinkedListNode<int>(35);
            // var node6 = new LinkedListNode<int>(11);

            // link.AddFirst(node1);
            // link.AddFirst(node2);
            // link.AddFirst(node3);
            // link.AddFirst(node4);
            // link.AddFirst(node5);
            // link.AddFirst(node6);

        }
    }
}
