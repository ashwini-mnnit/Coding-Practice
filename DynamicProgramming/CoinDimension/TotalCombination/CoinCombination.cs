public class CoinCombination {
    public int GetCoinCombination (int[] dim, int val) {
        int[, ] cache = new int[dim.Length, val + 1];

        /*
                    0   1   2   3   4   5   6   7   8   9   10  11  12
        2,          0   

        2,3         0

        2,3,5       0                                               [Final Ans]
        
        */

        for (int i = 0; i < dim.Length; i++) {
            cache[i, 0] = 0;
        }

        for (int i = 0; i < cache.GetLength (0); i++) {
            for (int j = 1; j < cache.GetLength (1); j++) {

                int val= j;

                //including dim[j]
                int x =

                //Excluding dim[j]
                int y = 

                cache[i][j] = x+y;
            }
        }

        return -1;
    }
}