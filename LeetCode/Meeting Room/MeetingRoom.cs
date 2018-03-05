using System;

namespace Meeting_Room {


    public class MeetingRoom {
        public bool CanAttendMeetings (Interval[] intervals) {
            Array.Sort(intervals,  new IntervalComparer());
        


        }
    }
}