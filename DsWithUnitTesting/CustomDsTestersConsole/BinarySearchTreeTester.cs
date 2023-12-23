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
        private readonly BstTraversal _bstTraversal = new();

        public void Test()
        {
            TestInsert();
            //TestFind();
            //TestRemove();

            //TestBreadFirstSearch();
            TestDepthFirstInOrder();
            TestDepthFirstPreOrder();
            TestDepthFirstPostOrder();
        }

        // left,right,current
        // 1,3,3,8,6,25,29,27,60,55,35,20
        private void TestDepthFirstPostOrder()
        {
            var result = _bstTraversal.DepthFirstSearchPostOrder(_binarySearchTree);
            WriteLine($"DFS Post Order: {string.Join(", ", result)}");
        }

        // current,left,right
        // 20,6,3,1,3,8,35,27,25,29,55,60
        private void TestDepthFirstPreOrder()
        {
            var result = _bstTraversal.DepthFirstSearchPreOrder(_binarySearchTree);
            WriteLine($"DFS Pre Order: {string.Join(", ", result)}");
        }

        // left,current,right
        // 1,3,3,6,8,20,25,27,29,35,55,60
        private void TestDepthFirstInOrder()
        {
            var result = _bstTraversal.DepthFirstSearchInOrder(_binarySearchTree);
            WriteLine($"DFS In Order: {string.Join(", ", result)}");
        }

        // 20,6,35,3,8,27,55,1,3,26,29,60
        private void TestBreadFirstSearch()
        {
            var result = _bstTraversal.BreadFirstSearch(_binarySearchTree);
            WriteLine($"BFS: {string.Join(", ", result)}");
        }



        private void TestRemove()
        {
            var items = new List<int>
            {
                60,
                29,
                27,
                20
            };
            foreach (var toRemove in items)
            {
                Remove(toRemove);
                WriteLine("\n");
            }
        }

        private void Remove(int toRemove)
        {
            Find(toRemove, out Node? node);
            if (node != null)
            {
                _binarySearchTree.Remove(toRemove);
                WriteLine($"After removing {toRemove}");
                Find(toRemove, out node);
            }
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
                Find(toFind, out Node? node);
            }
        }

        private void Find(int toFind, out Node? found)
        {
            found = _binarySearchTree.Find(toFind);
            WriteLine(found != null ? $"Found {found}" : $"{toFind} --- Not Found");
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
