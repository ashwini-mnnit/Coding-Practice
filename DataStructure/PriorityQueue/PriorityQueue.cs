using System;
using System.Collections;
using System.Collections.Generic;

namespace PriorityQueue {
    public class PriorityQueue<T> {
        private SortedSet<T> list;

        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }
       
        public PriorityQueue () {
            this.list = new SortedSet<T> ();
        }

        public PriorityQueue (IComparer<T> comparer) {
            this.list = new SortedSet<T> (comparer);
        }

        public void Add (T val) {
            this.list.Add (val);
        }

        public T Min () {
            return this.list.Min;
        }

        public void RemoveMin () {
            T item = this.list.Min;
            this.list.Remove(item);
        }
    }
}