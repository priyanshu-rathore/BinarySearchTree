namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(11);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(65);
            bst.Insert(63);
            bst.Insert(67);
            bst.Insert(22);
            bool search = bst.Search(60);
            int size = bst.Size();
            Console.WriteLine(search);

        }
    }
}