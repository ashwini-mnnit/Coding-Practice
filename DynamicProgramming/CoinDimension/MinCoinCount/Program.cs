using System;
class Program {
    static void Main (string[] args) {
        int[] dim = { 5, 3, 2, 1 };
        int val = 9;

        MinCoinCount sln = new MinCoinCount();

        Console.WriteLine (sln.GetMinCoinCount(dim, val));
    }
}