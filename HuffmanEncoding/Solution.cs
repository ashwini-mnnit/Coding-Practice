using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public HuffmanNode CreateHuffmanTree (List<Tuple<char, int>> inp) {
        HuffmanNode root = null;

        if (inp == null) {
            throw new ArgumentNullException (nameof (inp));
        }

        SortedSet<HuffmanNode> priorityQueue = new SortedSet<HuffmanNode> (new PQComparer ());

        foreach (Tuple<char, int> item in inp) {
            HuffmanNode node = new HuffmanNode (item.Item1, item.Item2);
            priorityQueue.Add(node);
        }

        while (priorityQueue.Count > 1) {
            HuffmanNode n1 = priorityQueue.Min;
            priorityQueue.Remove (n1);

            HuffmanNode n2 = priorityQueue.Min;
            priorityQueue.Remove (n2);

            HuffmanNode newInternalNode = new HuffmanNode (n1.feq + n2.feq);
            newInternalNode.left = n1;
            newInternalNode.right = n2;

            priorityQueue.Add (newInternalNode);
        }

        root = priorityQueue.Min;

        return root;
    }
}