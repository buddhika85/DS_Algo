using DSQuestions.BST;
using static System.Console;

namespace CustomDsTestersConsole
{
    //                     20
    //                    /   \
    //                    6    35
    //                   / \   /  \ 
    //                   3  8  27  55
    //                  / \    / \   \
    //                  1  3   25 29  60

    public class BinarySearchTreeTester
    {
        private readonly BinarySearchTree _binarySearchTree = new();

        public void Test()
        {
            TestInsert();
            TestFind();
        }

        private void TestFind()
        {
            var items = new List<int>
            {
                20, 6, 35, 3, 8, 1, 3, 27, 55, 25, 29, 60,      // available
                0, -1,-100,100              // not found
            };
            foreach (var toFind in items)
            {
                var found = _binarySearchTree.Find(toFind);
                WriteLine(found != null ? $"Found {found}" : $"{toFind} --- Not Found");
            }
        }

        private void TestInsert()
        {
            _binarySearchTree.Insert(20);

            _binarySearchTree.Insert(6);
            _binarySearchTree.Insert(35);

            _binarySearchTree.Insert(3);
            _binarySearchTree.Insert(8);

            _binarySearchTree.Insert(27);
            _binarySearchTree.Insert(55);

            _binarySearchTree.Insert(1);
            _binarySearchTree.Insert(3);

            _binarySearchTree.Insert(25);
            _binarySearchTree.Insert(29);

            _binarySearchTree.Insert(60);
        }
    }
}
