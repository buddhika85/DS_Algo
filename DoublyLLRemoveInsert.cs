using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    public class DoublyLLRemoveInsert
    {
        public void TestDoublyLLRemove()
        {
            var one = new DllNode { Value = 1 };
            var two = new DllNode { Value = 2 };
            var three = new DllNode { Value = 3 };
            var four = new DllNode { Value = 4 };
            var five = new DllNode { Value = 5 };

            one.LinkToNextDllNode(two);
            two.LinkToNextDllNode(three);
            three.LinkToNextDllNode(four);
            four.LinkToNextDllNode(five);

            var newDll = new DoublyLinkedList { Head = one, Tail = five };
            Console.WriteLine(newDll.ToString());

            var unavailableNode = new DllNode { Value = 5 };
            newDll.RemoveNode(unavailableNode);
            Console.WriteLine($"\nAfter removing unavailable - {unavailableNode.ToString()}");            
            Console.WriteLine(newDll.ToString());

            newDll.RemoveNode(one);
            Console.WriteLine("\nAfter removing first node");            
            Console.WriteLine(newDll.ToString());

            newDll.RemoveNode(five);
            Console.WriteLine("\nAfter removing last node");            
            Console.WriteLine(newDll.ToString());

            newDll.RemoveNode(three);
            Console.WriteLine("\nAfter removing middle node");            
            Console.WriteLine(newDll.ToString());
        }

        public void TestDoublyLLInsert()
        {
            var one = new DllNode { Value = 1 };
            var two = new DllNode { Value = 2 };
            var three = new DllNode { Value = 3 };
            var four = new DllNode { Value = 4 };

            one.LinkToNextDllNode(two);
            two.LinkToNextDllNode(three);
            three.LinkToNextDllNode(four);

            var newDll = new DoublyLinkedList { Head = one, Tail = four };
            Console.WriteLine(newDll.ToString());

            Console.WriteLine("Add 3 before 2");
            newDll.Insert(three, two);
            Console.WriteLine(newDll.ToString());

            var five = new DllNode { Value = 5 };

            one.LinkToNextDllNode(two);
            two.LinkToNextDllNode(three);
            three.LinkToNextDllNode(four);
            newDll = new DoublyLinkedList { Head = one, Tail = four };
            Console.WriteLine(newDll.ToString());

            Console.WriteLine("Add 5 before 2");
            newDll.Insert(five, two);
            Console.WriteLine(newDll.ToString());
        }
    }
}