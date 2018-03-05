
using System.Collections.Generic;

namespace Meeting_Room_II {
    public class Interval {
        public int start;
        public int end;
        public Interval () { start = 0; end = 0; }
        public Interval (int s, int e) { start = s; end = e; }
    }

    public class IntervalComparer: IComparer<Interval>
    {
        public int Compare(Interval x, Interval y)
        {
            return x.start.CompareTo(y.start);
        }
    }
}
