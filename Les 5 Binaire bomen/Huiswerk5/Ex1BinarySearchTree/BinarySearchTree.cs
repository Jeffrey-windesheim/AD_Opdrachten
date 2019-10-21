using System;
using System.Collections.Generic;

namespace Huiswerk5
{
    public class BinarySearchTree<T> : BinaryTree<T>, IBinarySearchTree<T>
        where T : System.IComparable<T>
    {

        private string number = "";

        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public void Insert(T x)
        {
           if(root == null)
            {
                root = new BinaryNode<T>(x, null, null);
                return;
            }
            BinaryNode<T> currentNode = root;
            while (currentNode != null)
            {
                var direction = currentNode.data.CompareTo(x) < 0;
                var nextNode = direction ? currentNode.right : currentNode.left;
                if (nextNode == null)
                {
                    if(direction)
                    {
                        currentNode.right = new BinaryNode<T>(x, null, null);
                    } else
                    {
                        currentNode.left = new BinaryNode<T>(x, null, null);
                    }
                    break;
                }
                currentNode = nextNode;
            }
        }

        public T FindMin()
        {
            return FindMin(root).data;
        }

        public BinaryNode<T> FindMin(BinaryNode<T> t)
        {
            if (t == null)
            {
                throw new BinarySearchTreeEmptyException();
            } else
            {
                while (t.left != null) {
                    t = t.left;
                }
                
                return t;
            }
        }

        public void RemoveMin()
        {
            BinaryNode<T> t = root;

            root = RemoveMin(t);
        }

        public BinaryNode<T> RemoveMin(BinaryNode<T> t)
        {
            if (t == null)
            {
                throw new BinarySearchTreeEmptyException();
            }
            else if (t.left != null)
            {
                t.left = RemoveMin(t.left);
                return t;
            }
            else
            {
                return t.right;
            }
        }

        public void Remove(T x)
        {
            Remove(x, root);
        }

        public BinaryNode<T> Remove(T x, BinaryNode<T> t)
        {
            if (t == null)
            {
                throw new BinarySearchTreeElementNotFoundException();
            }
            if (x.CompareTo(t.data) < 0)
            {
                t.left = Remove(x, t.left);
            }
            else if (x.CompareTo(t.data) > 0)
            {
                t.right = Remove(x, t.right);
            }
            else if (t.left != null && t.right != null)
            {
                t.data = FindMin(t.right).data;
                t.right = RemoveMin(t.right);
            }
            else
            {
                t = t.left ?? t.right;
            }
            return t;
        }

        public string InOrder()
        {
            try
            {
                return Order(root).Remove(number.Length - 1);
            } catch
            {
                number = "";
                return Order(root);
            }
            
        }

        public string Order(BinaryNode<T> t)
        {
            if (t != null)
            {
                Order(t.left);

                number += t.data + " ";

                Order(t.right);
            }

            return number;
        }

        public override string ToString()
        {
            return InOrder();
        }
    }
}
