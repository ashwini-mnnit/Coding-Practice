using System;

namespace Pelindrome {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            bool val = Test01 ();
            Console.WriteLine (val);
            val = Test02 ();
            Console.WriteLine (val);
            val = Test03 ();
            Console.WriteLine (val);

        }
        private static bool Test03 () {
            ListNode one = new ListNode (1);
            return new Solution ().IsPelindromeIterative (one);
        }
        private static bool Test02 () {
            ListNode one = new ListNode (1);
            ListNode two = new ListNode (2);
            ListNode three = new ListNode (3);
            ListNode four = new ListNode (4);
            ListNode five = new ListNode (2);
            ListNode six = new ListNode (1);
            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = six;
            return new Solution ().IsPelindromeIterative (one);
        }
        private static bool Test01 () {
            ListNode one = new ListNode (1);
            ListNode two = new ListNode (2);
            ListNode three = new ListNode (3);
            ListNode four = new ListNode (3);
            ListNode five = new ListNode (2);
            ListNode six = new ListNode (1);
            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = six;
            return new Solution ().IsPelindromeIterative (one);
        }
    }
}