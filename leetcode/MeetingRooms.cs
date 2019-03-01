using System;

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
        }
    }
}