using System;

namespace Huiswerk5
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Cunstructors
        //----------------------------------------------------------------------

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>
            {
                data = rootItem,
                left = null,
                right = null
            };
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                return root;
            }

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
            }
            else
            {
                return false;
            }
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            if (t2 == null)
            {
                root = new BinaryNode<T>(rootItem, t1.root, null);
            }
            else if (t1 == null)
            {
                root = new BinaryNode<T>(rootItem, null, t2.root);
            }
            else
            {
                root = new BinaryNode<T>(rootItem, t1.root, t2.root);
            }
        }

        public string ToPrefixString()
        {
            return Prefix(root);
        }

        public string Prefix(BinaryNode<T> t)
        {
            string tree = "";

            if (t != null)
            {
                tree += "[ " + t.data + " " + Prefix(t.left) + " " + Prefix(t.right) + " ]";
            }
            else
            {
                tree = "NIL";
            }

            return tree;
        }

        public string ToInfixString()
        {
            return Infix(root);
        }

        public string Infix(BinaryNode<T> t)
        {
            string tree = "";

            if (t != null)
            {
                tree += "[ " + Infix(t.left) + " " + t.data + " " + Infix(t.right) + " ]";
            }
            else
            {
                tree = "NIL";
            }

            return tree;
        }

        public string ToPostfixString()
        {
            return Postfix(root);
        }

        public string Postfix(BinaryNode<T> t)
        {
            string tree = "";

            if (t != null)
            {
                tree += "[ " + Postfix(t.left) + " " + Postfix(t.right) + " " + t.data + " ]";
            }
            else
            {
                tree = "NIL";
            }

            return tree;
        }

        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            return Nleaves(root);
        }

        public int Nleaves(BinaryNode<T> leave)
        {
            int count = 0;
            if (leave != null)
            {
                if (leave.left == null && leave.right == null)
                {
                    count++;
                }
                else
                {
                    count = count + Nleaves(leave.left) + Nleaves(leave.right);
                }
            }
            return count;
        }

        public int NumberOfNodesWithOneChild()
        {
            return N1child(root);
        }

        public int N1child(BinaryNode<T> node)
        {
            int count = 0;
            if (node != null)
            {
                if (node.left != null && node.right == null)
                {
                    count++;
                }
                else if (node.left == null && node.right != null)
                {
                    count++;
                }
                else
                {
                    count = count + N1child(node.left) + N1child(node.right);
                }
            }
            return count;
        }

        public int NumberOfNodesWithTwoChildren()
        {
            return N2children(root);
        }

        public int N2children(BinaryNode<T> node)
        {
            int count = 0;
            if (node != null)
            {
                if (node.left != null && node.right != null)
                {
                    count = count + 1 + N2children(node.left) + N2children(node.right);
                }
                else
                {
                    count = count + N2children(node.left) + N2children(node.right);
                }
            }
            return count;
        }
    }
}