using System;

namespace SerializeTree {
    class Program {
        static void Main (string[] args) {
            TreeNode One = new TreeNode (1);
            TreeNode Two = new TreeNode (2);
            TreeNode Three = new TreeNode (3);

            //One.Left= Two;
            //One.Right = Three;

            Solution sln = new Solution ();
            //Console.WriteLine(sln.Serialize(One));

            One.Left = Two;
            Two.Left = Three;
            //PrintTree(One, "   ", false);

            string treestring = sln.Serialize(One);
            Console.WriteLine (treestring);

            TreeNode tree = sln.Deserialize(treestring);

            Console.WriteLine (sln.Serialize (One));

        }

        public static void PrintTree (TreeNode tree, String indent, bool last) {
            
            if(tree == null)
            {
                return;
            }

            Console.Write (indent + "+- " + tree.Val);
            
            indent += last ? "   " : "|  ";

            PrintTree (tree.Left, indent, false);
            PrintTree (tree.Right, indent, true);
            
        }
    }
}