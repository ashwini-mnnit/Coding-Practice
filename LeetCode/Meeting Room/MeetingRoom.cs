using System;

namespace Meeting_Room {


    public class MeetingRoom {
        public bool CanAttendMeetings (Interval[] intervals) {
            Array.Sort(intervals,  new IntervalComparer());

            for(int i=0; i< intervals.Length;i++)
            {
                if(i< intervals.Length-1)
                {
                    if(intervals[i+1].start < intervals[i].end)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}