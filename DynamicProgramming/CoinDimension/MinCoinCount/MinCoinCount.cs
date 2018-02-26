/*

https://www.geeksforgeeks.org/find-minimum-number-of-coins-that-make-a-change/

Given a value V, if we want to make change for V cents, and we have infinite supply of each of C = { C1, C2, .. , Cm} valued coins, what is the minimum number of coins to make the change?

Examples:

Input: coins[] = {25, 10, 5}, V = 30
Output: Minimum 2 coins required
We can use one coin of 25 cents and one of 5 cents 

Input: coins[] = {9, 6, 5, 1}, V = 11
Output: Minimum 2 coins required
We can use one coin of 6 cents and 1 coin of 5 cents


Solution 1: Recurssive :: sort diminssion and try to make with the largest one

Solution 2: DP.



*/

using System;

public class MinCoinCount {
    public int GetMinCoinCount (int[] dim, int val) {
        int[] tab = new int[val + 1];
        tab[0] = 0;

        for (int i = 0; i <= val; i++) {
            tab[i] = System.Int32.MaxValue;
        }

        tab[0] = 0;

        for (int i = 1; i <= val; i++) {
            if(IsDimensionContains(dim, i))
            {
               // tab[i]=1;
               // continue;
            }

            for (int j = 0; j < dim.Length; j++) { 

                if(dim[j]==i)
                {
                    tab[i]=1;
                    break;
                }             
                if (dim[j] < i) {
                    int temp = tab[i-dim[j]];
                    if (temp + 1 < tab[i]) {
                        tab[i] = temp+1;
                    }
                }
            }
        }

        return tab[val];

    }

    private bool IsDimensionContains(int[] dim, int i)
    {
        foreach(int k in dim)
        {
            if(k==i)
            {
                return true;
            }
        }

        return false;
    }
}