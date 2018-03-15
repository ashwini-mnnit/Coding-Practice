using System;
using System.Collections.Generic;
using System.Text;

namespace Smallest_Substring_of_All_char {
    class Program {
        static void Main (string[] args) {

            char[] arr = { 'A', 'B', 'C' };
            string str = "ADOBECODEBANCDDD";
            Console.WriteLine ("SS: " + GetShortestUniqueSubstring (arr, str));
        }
        public static string GetShortestUniqueSubstring (char[] arr, string str) {
            if (str.Length == 0) {
                return "";
            }
            // your code goes here
            Dictionary<char, int> countMap = new Dictionary<char, int> ();
            //Build hashSet

            HashSet<char> hashSet = GetUniqueHashSet (arr);
            int end = 0, start = 0;
            int fend = 0, fstart = 0;
            int min = Int32.MaxValue;
            bool anytarget = false;

            while (end < str.Length) {
                char val = str[end++];

                // Update hashMap
                if (hashSet.Contains (val)) {
                    if (countMap.ContainsKey (val)) {
                        countMap[val]++;
                    } else {
                        countMap.Add (val, 1);
                    }
                }

                // Slide the window, if required
                if (countMap.Count == hashSet.Count) {
                    anytarget = true;
                    while (start < end) {
                        char val2 = str[start++];
                        if (hashSet.Contains (val2)) {
                            if (--countMap[val2] == 0) {
                                countMap.Remove (val2);
                                break;
                            }
                        }

                    }
                    if (min > (end - start)) {
                        min = end - start;
                        fend = end;
                        fstart = start-1;
                    }
                }
            }
            if (fstart == fend || anytarget == false) {
                return "";
            }

            StringBuilder sb = new StringBuilder ();
            for (int i = fstart; i < fend; i++) {
                sb.Append (str[i].ToString ());
            }

            return sb.ToString ();
        }

        private static HashSet<char> GetUniqueHashSet (char[] arr) {
            HashSet<char> rv = new HashSet<char> ();
            foreach (char c in arr) {
                rv.Add (c);
            }
            return rv;

        }
    }

}