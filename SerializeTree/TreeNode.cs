using System;

namespace SerializeTree {
    public class TreeNode {
        public static TreeNode NullNode = new TreeNode ();

        private int val;
        private TreeNode left;
        private TreeNode right;

        private TreeNode () {

        }

        public TreeNode (int val) {
            this.val = val;
            this.left = null;
            this.right = null;
        }

        public TreeNode Left {
            get => left;
            set {
                left = value;
            }
        }
        public TreeNode Right {
            get => right;
            set {
                right = value;
            }
        }

        public int Val {
            get => val;
            set {
                val = value;
            }
        }
    }
}