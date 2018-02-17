using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeTree {
    public class Solution {

        public string Serialize (TreeNode root) {

            if (root == null) {
                return "";
            }

            List<string> rvList = new List<string> ();

            Queue<TreeNode> bfsQueue = new Queue<TreeNode> ();
            bfsQueue.Enqueue (root);
            while (bfsQueue.Count != 0) {
                TreeNode node = bfsQueue.Dequeue ();

                if (node == TreeNode.NullNode) {
                    rvList.Add ("null");
                    continue;
                } else {
                    rvList.Add (node.Val.ToString ());
                }

                // add Left and right Childs
                if (node.Left != null) {
                    bfsQueue.Enqueue (node.Left);
                } else {
                    bfsQueue.Enqueue (TreeNode.NullNode);
                }

                if (node.Right != null) {
                    bfsQueue.Enqueue (node.Right);
                } else {
                    bfsQueue.Enqueue (TreeNode.NullNode);
                }

                //Console.WriteLine(node == TreeNode.NullNode? rvList.Add("null"):rvList.Add("null"));

            }

            // Generate String from the list of string
            for (int i = rvList.Count - 1; i >= 0; i--) {
                if (!rvList[i].Equals ("null")) {
                    break;
                }
                rvList.RemoveAt (i);
            }

            // Create SB from 
            StringBuilder sb = new StringBuilder ();

            foreach (string s in rvList.ToArray ()) {
                sb.Append (s).Append (",");
            }

            return sb.ToString ();
        }

        public TreeNode Deserialize (string tree) {
            if (tree.Equals ("")) {
                return null;
            }

            string[] nodes = tree.Split (',');

            Queue<TreeNode> bfsQueue = new Queue<TreeNode> ();

            // Add first Node 
            TreeNode node1 = new TreeNode (Int32.Parse (nodes[0]));
            TreeNode root = node1;

            bfsQueue.Enqueue (node1);

            int iter = 1;

            while (bfsQueue.Count != 0) {
                
                TreeNode node = bfsQueue.Dequeue();
                
                if(node== TreeNode.NullNode)
                {
                    node= null;
                    continue;
                }
                
                if(iter<nodes.Length-2){

                TreeNode left =  GetNode(nodes, ref iter);
                TreeNode right = GetNode(nodes, ref iter);

                bfsQueue.Enqueue(left);
                bfsQueue.Enqueue(right);

                node.Left= left;
                node.Right = right;
                }
            }


            return node1;
        }

        private TreeNode GetNode (string[] nodes, ref int iter) {
            TreeNode node;
            if (nodes[iter].Equals ("null")) {
                node = TreeNode.NullNode;
            } else {
                node = new TreeNode (Int32.Parse (nodes[iter]));
            }
            iter++;

            return node;
        }
    }
}