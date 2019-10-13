using System;

namespace Huiswerk4
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        private BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Cunstructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root.data = rootItem;
            root.left = root.right = null;
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            return root;
        }

        public int Size()
        {
            return Size(root);
        }

        public int Size(BinaryNode<T> t)
        {
            if (t == null)
            {
                return 0;
            }
            else
            {
                return 1 + Size(t.left) + Size(t.right);
            }
        }

        public int Height()
        {
            return Height(root);
        }

        public int Height(BinaryNode<T> t)
        {
            if (t == null)
            {
                return -1;
            }
            else
            {
                return 1 + Math.Max(Height(t.left), Height(t.right));
            }
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            if (Size() == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            if (t1.root == t2.root && t1.root != null)
            {
                throw new Exception("illegal argument");
            }

            root = new BinaryNode<T>(rootItem, t1.root, t2.root);

            if(this != t1)
            {
                t1.root = null;
            }
            if(this != t2)
            {
                t2.root = null;
            }
        }

        public string ToPrefixString()
        {
            throw new System.NotImplementedException();
        }

        public string ToInfixString()
        {
            throw new System.NotImplementedException();
        }

        public string ToPostfixString()
        {
            throw new System.NotImplementedException();
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithOneChild()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfNodesWithTwoChildren()
        {
            throw new System.NotImplementedException();
        }

    }
}