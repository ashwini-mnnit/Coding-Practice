using System;

namespace IO_Problem3 {
    public class Solution {
        int ReturnAndReset (ref int cnt) {
            int rv = cnt;
            cnt = 0;
            return rv;
        }
        public int GetSubStringCount (string str) {
            int cOne = 0;
            int cZero = 0;

            int count = 0;
            char curChar = str[0];
            for (int i = 0; i < str.Length; i++) {

                // flip
                if (!str[i].Equals (curChar)) {

                    count += Math.Min (cZero, cOne);
                    if (curChar.Equals ('0')) {
                        cOne = 0;
                    } else {
                        cZero = 0;
                    }

                    curChar = str[i];
                }

                if (str[i].Equals ('0')) cZero++;
                if (str[i].Equals ('1')) cOne++;
            }

            count += Math.Min (cZero, cOne);
            return count;
        }
    }
}