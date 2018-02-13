using System.Collections.Generic;

public class PQComparer : IComparer<HuffmanNode> {
    int IComparer<HuffmanNode>.Compare (HuffmanNode x, HuffmanNode y) {

        var res = x.feq.CompareTo (y.feq);

        if (res == 0) {
            return 1;
        }
        return res;
    }
}