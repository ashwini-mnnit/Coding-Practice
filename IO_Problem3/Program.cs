using System;

namespace IO_Problem3 {
    class Program {
        static void Main (string[] args) {
            Solution sln = new Solution ();
            string str = "11100001100";
            Console.WriteLine (sln.GetSubStringCount (str));
        }
    }
}


/*

Next problem
https://www.geeksforgeeks.org/largest-subarray-with-equal-number-of-0s-and-1s/

and 

https://www.geeksforgeeks.org/find-the-largest-subarray-with-0-sum/



 */