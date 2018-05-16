using System;

namespace int237 {
    public class Solution {
        public int int237 (int[] arr) {
            string operators = "+-*/";
            int count = int237Util(arr, 0, operators, '&', 0);
            return count;
        }

        private int int237Util (int[] arr, int pos, string op, char curOp, int CountSum) {
            if (pos == arr.Length) {
                if (CountSum == 237) {
                    return 1;
                }
                return 0;
            }

            if (curOp.Equals ('&')) {
                CountSum = arr[pos];
            } else {
                CountSum = ApplyOperator (curOp, arr[pos], CountSum);
            }
            int count =0;
            foreach (char opx in op) {
                count+=int237Util (arr, pos+1, op, opx, CountSum);
            }

            return count;

        }

        private int ApplyOperator (char curOp, int v, int countSum) {
            switch (curOp) {
                case '+':
                    countSum += v;
                    break;
                case '-':
                    countSum -= v;
                    break;
                case '*':
                    countSum *= v;
                    break;
                case '/':
                    if(v!=0)
                        countSum /= v;
                    break;
            }

            return countSum;
        }

    }
}