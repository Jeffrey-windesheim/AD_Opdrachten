using System;

namespace Huiswerk4
{
    public class FirstChildNextSibling<T> : IFirstChildNextSibling<T>
    {
        public FCNSNode<T> root;

        public int Size()
        {
            return Size(root);
        }

        public int Size(FCNSNode<T> t)
        {
            if (t == null)
            {
                return 0;
            }
            else
            {
                return 1 + Size(t.firstChild) + Size(t.nextSibling);
            }
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(root, 0);
        }

        public void PrintPreOrder(FCNSNode<T> t, int subLevel)
        {
            if (t == null)
            {
                return;
            }

            for (int i = 0; i < subLevel; i++)
            {
                Console.Write("  ");
            }

            int count = 0;
            while (t != null)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(t.data);
                if (t.firstChild != null)
                {
                    subLevel++;
                    PrintPreOrder(t.firstChild, subLevel);
                }
                t = t.nextSibling;
                count++;
            }
        }

        public override string ToString()
        {
            string tree;

            if (root == null)
            {
                tree = "NIL";
            }
            else
            {
                tree = root.data.ToString() + ",";
                tree += StringBuilder(root);
            }

            return tree;
        }

        public string StringBuilder(FCNSNode<T> t)
        {
            string tree = "";

            if (t.firstChild != null)
            {
                string ending = "),";
                if (t.nextSibling == null)
                {
                    ending = ")";
                }

                if (StringBuilder(t.firstChild) != "")
                {
                    tree += "FC(" + t.firstChild.data + "," + StringBuilder(t.firstChild) + ending;
                } else
                {
                    tree += "FC(" + t.firstChild.data + ending;
                }
            }

            if (t.nextSibling != null)
            {
                if (StringBuilder(t.nextSibling) != "")
                {
                    tree += "NS(" + t.nextSibling.data + "," + StringBuilder(t.nextSibling) + ")";
                }
                else
                {
                    tree += "NS(" + t.nextSibling.data + ")";
                }
            }

            return tree;
        }

    }
}