using System;

namespace Binary_Search_Tree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tree = new Tree();

            tree.Insert(25);
            tree.Insert(20);
            tree.Insert(15);
            tree.Insert(27);
            tree.Insert(30);
            tree.Insert(29);
            tree.Insert(26);
            tree.Insert(22);
            tree.Insert(32);

            tree.TraverseInOrder();

            Console.WriteLine();
            tree.Delete(25);
            tree.TraverseInOrder();

            Console.WriteLine();
            tree.Delete(100);
            tree.TraverseInOrder();

            Console.WriteLine();
            tree.Delete(27);
            tree.TraverseInOrder();

            Console.WriteLine();
            Console.WriteLine(tree.Search(15));
            Console.WriteLine(tree.Search(55));
            Console.WriteLine(tree.Search(29));

            Console.WriteLine();
            Console.WriteLine(tree.GetMin());
            Console.WriteLine(tree.GetMax());

            Console.Read();
        }
    }
}
