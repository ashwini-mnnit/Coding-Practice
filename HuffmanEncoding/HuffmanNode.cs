public class HuffmanNode {
    // Char, Frequency tuple
    public char? charVal;
    public int feq;

    public HuffmanNode (char? charVal, int feq) {
        this.charVal = charVal;
        this.feq = feq;
    }

    public HuffmanNode (int feq) {

        this.feq = feq;
    }

    public bool IsInternalNode () {
        return charVal == null;
    }

    public HuffmanNode left;
    public HuffmanNode right;

}