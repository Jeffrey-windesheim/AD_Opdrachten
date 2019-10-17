namespace Huiswerk4
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public class DSBuilder
    {
        public static Sorter CreateQuickSorter()
        {
            return new QuickSort();
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Empty ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();
            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Small ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();

            FCNSNode<string> d = new FCNSNode<string> ("d");
            FCNSNode<string> c = new FCNSNode<string> ("c");
            FCNSNode<string> b = new FCNSNode<string> ("b", d, c);
            FCNSNode<string> a = new FCNSNode<string> ("a", b, null);

            tree.root = a;

            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_18_3 ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string>();

            FCNSNode<string> k = new FCNSNode<string>("k");
            FCNSNode<string> h = new FCNSNode<string>("h");
            FCNSNode<string> g = new FCNSNode<string>("g");
            FCNSNode<string> j = new FCNSNode<string>("j", k, null);
            FCNSNode<string> i = new FCNSNode<string>("i", null, j);
            FCNSNode<string> e = new FCNSNode<string>("e", i, null);
            FCNSNode<string> d = new FCNSNode<string>("d", h, e);
            FCNSNode<string> c = new FCNSNode<string>("c", null, d);
            FCNSNode<string> f = new FCNSNode<string>("f", null, g);
            FCNSNode<string> b = new FCNSNode<string>("b", f, c);
            FCNSNode<string> a = new FCNSNode<string>("a", b, null);

            tree.root = a;

            return tree;
        }

        public static IBinaryTree<int> CreateBinaryTreeEmpty()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            return tree;
        }

        //
        //         5
        //       /   \
        //     2       6
        //    / \
        //   8   7
        //      /
        //     1
        //
        public static IBinaryTree<int> CreateBinaryTreeInt()
        {
            BinaryTree<int> t1 = new BinaryTree<int>(1);
            BinaryTree<int> t8 = new BinaryTree<int>(8);
            BinaryTree<int> t6 = new BinaryTree<int>(6);
            BinaryTree<int> t7 = new BinaryTree<int>();
            BinaryTree<int> t2 = new BinaryTree<int>();
            BinaryTree<int> t5 = new BinaryTree<int>();

            t7.Merge(7, t1, null);
            t2.Merge(2, t8, t7);
            t5.Merge(5, t2, t6);

            return t5;
        }

        //
        //         t
        //       /   \
        //     w       a
        //    / \     / \
        //   q   g   o   p
        public static IBinaryTree<string> CreateBinaryTreeString()
        {
            BinaryTree<string> tq = new BinaryTree<string>("q");
            BinaryTree<string> tg = new BinaryTree<string>("g");
            BinaryTree<string> to = new BinaryTree<string>("o");
            BinaryTree<string> tp = new BinaryTree<string>("p");
            BinaryTree<string> tw = new BinaryTree<string>();
            BinaryTree<string> tt = new BinaryTree<string>();
            BinaryTree<string> ta = new BinaryTree<string>();

            tw.Merge("w", tq, tg);
            ta.Merge("a", to, tp);
            tt.Merge("t", tw, ta);

            return tt;
        }
    }
}