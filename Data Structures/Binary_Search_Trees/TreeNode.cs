using System;

namespace Binary_Search_Tree
{
    internal class TreeNode
    {
        public int Data { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int data)
        {
            Data = data;
        }

        public void Insert(int value)
        {
            if (value == Data)
                return;

            if (value < Data)
            {
                if(LeftChild == null)
                    LeftChild = new TreeNode(value);
                else
                    LeftChild.Insert(value);
            }
            else
            {
                if(RightChild == null)
                    RightChild = new TreeNode(value);
                else
                    RightChild.Insert(value);
            }
        }

        public void TraverseInOrder()
        {
            if(LeftChild != null)
                LeftChild.TraverseInOrder();

            Console.Write(Data + ", ");

            if(RightChild != null)
                RightChild.TraverseInOrder();
        }

        public TreeNode Search(int value)
        {
            if (value == Data)
                return this;

            if (value < Data)
            {
                if (LeftChild != null)
                    return LeftChild.Search(value);
            }
            else
            {
                if (RightChild != null)
                    return RightChild.Search(value);
            }

            return null;
        }

        public int GetMin()
        {
            if (LeftChild == null)
                return Data;
            return LeftChild.GetMin();

        }

        public int GetMax()
        {
            if (RightChild == null)
                return Data;
            return RightChild.GetMax();
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
