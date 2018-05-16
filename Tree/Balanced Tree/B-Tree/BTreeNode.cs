using System.Collections.Generic;

namespace B_Tree
{

    public class BTreeNode
    {
        private IList<int> keys;
        private IList<int> childs;

        public BTreeNode(int val)
        {

        }
        
        public bool isLeaf
        {
            get
            {
                return this.childs.Count==0;
            }
        }
    }
}
