using System;

namespace UC_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST<int> bst = new BST<int>(56);
            bst.add(30);
            bst.add(70);
            bst.show();
        }
    }
}
