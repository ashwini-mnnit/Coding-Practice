using System;

namespace Meeting_Room_II {
    public class MeetingRoom2 {
        public int minMeetingRooms (Interval[] intervals) {

            if (intervals == null || intervals.Length == 0) {
                return 0;
            }

            // Sort on increasing order  of start time.
            Array.Sort (intervals, new IntervalComparer ());

            SortedSet<Interval> pq = new SortedSet<Interval>();
        }
    }
}