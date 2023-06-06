using System.Collections;

namespace DS_Algo
{
    /*
    Cycle Detection	
    "You are given the head of a linked list. Check if there is a cycle and if yes,  return the node where the cycle begins. If there is no cycle, return null. 
     There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Do not modify the linked list. "

    0 -> 1 -> 2 -> 1 -> 5 -> null - cycle begins at index 1 (because index 3 also points to node with value 1) => return node at index 1
    0 -> 1 -> 2 -> 4 -> 5 -> null - no cycle here - return null
    */
    public class SinglyLinkedListCycleDetection
    {
        public void TestGetCycleStartNode()
        {
            var sll = new SinglyLinkedList();
            sll.AddAtIndex(0, 0);
            sll.AddAtIndex(1, 1);
            sll.AddAtIndex(2, 2);
            sll.AddAtIndex(3, sll.Get(1).Value);
            sll.AddAtIndex(4, 5);

            Console.WriteLine(sll.ToString());  // 0 -> 1 -> 2 -> 1 -> 5
            var cycleStartNode = GetCycleStartNode(sll.Head);
            if (cycleStartNode != null)
            {
                Console.WriteLine($"Cycle start node: {cycleStartNode.Value}");
            }
            else
            {
                Console.WriteLine($"No cycle detected");
            }

            sll.DeleteAtIndex(3);
            Console.WriteLine($"\nRemoved Cycle Node: {sll.ToString()}");
            sll.AddAtIndex(3, 4);
            Console.WriteLine(sll.ToString());  // 0 -> 1 -> 2 -> 1 -> 5
            cycleStartNode = GetCycleStartNode(sll.Head);
            if (cycleStartNode != null)
            {
                Console.WriteLine($"Cycle start node: {cycleStartNode.Value}");
            }
            else
            {
                Console.WriteLine($"No cycle detected");
            }
        }

        public Node? GetCycleStartNode(Node head)
        {
            var node = head;
            var dictionary = new Dictionary<int, Node>();
            while(node != null)
            {                
                if (dictionary.ContainsKey(node.Value))
                {
                    // already sean this node
                    return dictionary[node.Value];
                }
                else
                {
                    dictionary.Add(node.Value, node);
                }
                node = node.Next;
            }
            return null;    // no cycle
        }
    }
}