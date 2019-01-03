namespace Binary_Search_Tree
{
    internal class Tree
    {
        public TreeNode Root { get; set; }

        public void Insert(int value)
        {
            if(Root == null)
                Root = new TreeNode(value);
            
            Root.Insert(value);
        }

        public void TraverseInOrder()
        {
            if(Root != null)
                Root.TraverseInOrder();
        }

        public TreeNode Search(int value)
        {
            return Root != null ? Root.Search(value) : null;
        }

        public int GetMin()
        {
            if (Root == null)
                return int.MinValue;
            return Root.GetMin();
        }

        public int GetMax()
        {
            if (Root == null)
                return int.MaxValue;
            return Root.GetMax();
        }

        public void Delete(int value)
        {
            Root = DeleteNode(Root, value);
        }

        private static TreeNode DeleteNode(TreeNode subTreeNode, int value)
        {
            if (subTreeNode == null)
                return null;

            if (value < subTreeNode.Data)
            {
                subTreeNode.LeftChild = DeleteNode(subTreeNode.LeftChild, value);
            }
            else if (value > subTreeNode.Data)
            {
                subTreeNode.RightChild = DeleteNode(subTreeNode.RightChild, value);
            }
            else
            {
                if (subTreeNode.LeftChild == null)
                {
                    return subTreeNode.RightChild;
                }

                if (subTreeNode.RightChild == null)
                {
                    return subTreeNode.LeftChild;
                }

                subTreeNode.Data = subTreeNode.RightChild.GetMin();
                subTreeNode.RightChild = DeleteNode(subTreeNode.RightChild, subTreeNode.Data);
            }

            return subTreeNode;
        }

        public override string ToString()
        {
            return Root.ToString();
        }
    }
}
