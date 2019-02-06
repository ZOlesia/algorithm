using System;
// using System.Collections.Generic;
using System.Text;
using System.Collections;
// using System.Collections.IEnumerable;

namespace LinkedListss
{
    class Program
    {
        public class Node
        {
            Node next = null;
            int data;
            public Node(int d){
                next = d;
            }
        }

        public static void RemoveDups(LinkedListNode n){
            LinkedListNode previous = null;
            var arr = new HashSet<int>();
            while(n != null){
                if(arr.Contains(n.data)){
                    previous.next = n.next;
                }
                else{
                    arr.Add(n.data);
                    previous = n;
                }
                n = n.next;
            }
        }

        public static LinkedListNode NthToLast(LinkedListNode head, int k){
            var current = head;
            var follower = head;
            var count = 0;
            while(current.Next != null){
                if(count != k){
                    count++;
                } else if(count == k){
                    follower = follower.Next;
                }
                current = current.Next;
            }
            return follower;
        }

        public static bool DeleteMiddleNode(LinkedListNode node){
            if(node == null) return false;
            if(node.next == null){
                node = null;
                return true;
            }

            var nextNode = node.next;
            node.data = nextNode.data;
            node.next = nextNode.next;
            return true;

        }

        public static LinkedListNode Partition(LinkedListNode head, int p){
            var runner = head;
            var previous = null;
            while(runner != null){
                if(runner.Value < p){
                    var holder = runner;
                    previous.next = runner.next;
                    holder.next = head.next;
                    head.next = holder;
                    runner = previous;
                }
                previous = runner;
                runner = runner.next;
            }
            return head;
        }
        static void Main(string[] args)
        {
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
