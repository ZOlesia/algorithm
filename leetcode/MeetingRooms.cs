using System;
using System.Collections.Generic;

namespace leetcode
{
    public class MeetingRooms
    {
        public class Interval
        {
            int start;
            int end;
            Interval(){
                start = 0;
                end = 0;
            }

            Interval(int s, int e){
                start = s;
                end = e;
            }

            public static bool canAttendMeeting(Interval[] intervals){
                var starts = new int[intervals.Length];
                var ends = new int[intervals.Length];

                for(int i = 0; i < intervals.Length; i++){
                    starts[i] = intervals[i].start;
                    ends[i] = intervals[i].end;
                }

                Array.Sort(starts);
                Array.Sort(ends);

                for(int i = 0; i < starts.Length - 1; i++){
                    if(starts[i+1] < ends[i]){
                        return false;
                    }
                }

                return true;
            }



            // count the minimum number of the meeting rooms
            // public static int minMeetingRooms(Interval[] intervals){
            //     if(intervals == null || intervals.Length == 0){
            //         return 0;
            //     }

            //     Array.Sort(intervals, (a, b) => a.start - b.start);

            //     Queue<Interval> minHeap = new Queue<Interval>((a, b) => a.end - b.end));  // ((a, b) => a.end - b.end) ---> minHeap by the end values (have to figure it out in C#)

            //     minHeap.Enqueue(intervals[0]);

            //     for(int i = 1; i < intervals.Length; i++){
            //         var current = intervals[i];
            //         var eraliest = minHeap.Dequeue();

            //         if(current.start >= eraliest.end){
            //             eraliest.end = current.end;
            //         } else {
            //             minHeap.Enqueue(current);
            //         }

            //         minHeap.Enqueue(eraliest);
            //     }

            //     return minHeap.Count;
            // }
        }
    }
}