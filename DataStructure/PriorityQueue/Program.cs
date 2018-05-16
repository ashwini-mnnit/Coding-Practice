using System;
using System.Collections.Generic;

namespace PriorityQueue
{
    public class MyComaparerSupportDuplicate: IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int result = x.CompareTo(y);
            if(result==0)
            {
                return 1;
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int> queue = new PriorityQueue<int>(new MyComaparerSupportDuplicate());

            for(int i = 0; i<10 ;i++)
            {
                queue.Add(10-i);
            }

            queue.Add(10);

            while(queue.Count!=0)
            {
                Console.WriteLine(queue.Min());
                queue.RemoveMin();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
