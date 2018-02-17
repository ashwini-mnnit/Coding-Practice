using System;

namespace LRU
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache<int, int> cache = new LRUCache<int, int>(3);

            cache.Add(1,1);
            cache.Add(2,2);
            cache.Add(3,3);
            cache.Get(1);
            cache.Add(4,4);
            Console.WriteLine("Hello World!");
        }
    }
}
